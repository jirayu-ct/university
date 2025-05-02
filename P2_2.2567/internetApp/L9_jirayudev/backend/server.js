const express = require('express')
const bodyParser = require('body-parser')
const mysql = require('mysql2/promise')
const cors = require('cors')

const app = express()
app.use(bodyParser.json())
app.use(cors())

let conn = []
const initMySQL = async () => {
    conn = await mysql.createConnection({
        host: 'localhost',
        user: 'root',
        password: '',
        database: 'company_hoomwork_restAPI',
        port: 3306
    })
}


const PORT = 3000
app.listen(PORT, async () => {
    await initMySQL();
    console.log(`Server is running on port ${PORT}`);
})

//1.เรียกดูข้อมูลทั้งหมด
app.get('/customers', async (req, res) => {
    try {
        const results = await conn.query('SELECT * FROM customers')
        res.json(results[0])
    }
    catch (error) {
        console.error('Error fetching customers: ', error.message)
        res.status(500).json({ error: 'Error fetching customers' })
    }
})

app.get('/customer/:id', async (req, res) => {
    let id  = parseInt(req.params.id)
    try {
        const results = await conn.query('SELECT * FROM customers WHERE CustomerID = ?', [id])
        res.json(results[0])
    }
    catch (error) {
        console.error('Error fetching customers: ', error.message)
        res.status(500).json({ error: 'Error fetching customers' })
    }
})

// 3.เพิ่มข้อมูล
app.post('/customer', async (req, res) => {
    try{
        const customer = req.body;
        const results = await conn.query('INSERT INTO customers SET ?', customer);
        res.json({
            message: 'insert ok.',
            data: results[0]
        })
    }
    catch (error) {
        console.error('Error fetching post customer: ', error.message)
        res.status(500).json({ 
            message: error.message 
        })
    }
})

// 4.ปรับปรุงข้อมูลทั้งหมด
app.put('/customer/:id', async (req, res) => {
    try{
        let id = parseInt(req.params.id);
        let updateUser = req.body;
        
        const results = await conn.query('UPDATE customers SET ? WHERE CustomerID = ?', [updateUser, id])

        res.json({
            message: 'update ok',
            data: results[0]
        })
    }
    catch (error) {
        console.error("Error message", error.message)
        res.status(500).json({
            message: 'something wrong'
        })
    }
})

// 5.ปรับปรุงข้อมูลบางส่วน
app.patch('/customers/:id', async (req, res) => {
    try {
        let id = parseInt(req.params.id);
        if (isNaN(id)) {
            return res.status(400).json({ message: 'Invalid ID' });
        }

        let updateUser = req.body;

        const [rows] = await conn.query('SELECT * FROM customers WHERE CustomerID = ?', [id]);
        if (rows.length === 0) {
            return res.status(404).json({ message: 'User not found' });
        }

        await conn.query('UPDATE customers SET ? WHERE CustomerID = ?', [updateUser, id]);

        const [updatedUser] = await conn.query('SELECT * FROM customers WHERE CustomerID = ?', [id]);

        res.json({
            message: 'User updated successfully',
            data: updatedUser[0]
        });
    } catch (error) {
        console.error('Error message:', error.message);
        res.status(500).json({ message: 'Something went wrong' });
    }
});


app.delete('/customer/:id', async (req, res) => {
    try {
        let id = parseInt(req.params.id);
        if (isNaN(id)) {
            return res.status(400).json({ message: 'Invalid ID' });
        }

        const [rows] = await conn.query('SELECT * FROM customers WHERE CustomerID = ?', [id]);
        if (rows.length === 0) {
            return res.status(404).json({ message: 'User not found' });
        }

        await conn.query('DELETE FROM customers WHERE CustomerID = ?', [id]);

        res.json({
            message: 'User deleted successfully'
        });
    } catch (error) {
        console.error('Error message:', error.message);
        res.status(500).json({ message: 'Something went wrong' });
    }
});