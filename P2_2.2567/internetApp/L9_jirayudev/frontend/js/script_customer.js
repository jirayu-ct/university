document.addEventListener('DOMContentLoaded', () => {
    const BASE_URL = "http://localhost:3000";
    const CustomersTable = document.querySelector('#CustomersTable tbody');

    const fetchCustomers = async () => {
        try {
            const res = await fetch(`${BASE_URL}/customers`);
            const customer = await res.json();

            console.log(customer);

            CustomersTable.innerHTML = '';
            customer.forEach(customer => {
                console.log(`ID: ${customer.CustomerID} FirstName: ${customer.FirstName} LastName: ${customer.LastName} Email: ${customer.Email} Phone: ${customer.PhoneNumber} Address: ${customer.Address} CreatedAt: ${customer.CreatedAt}`);
                const tr = document.createElement('tr');
                tr.innerHTML = `
                    <td>${customer.CustomerID}</td>
                    <td>${customer.FirstName}</td>
                    <td>${customer.LastName}</td>
                    <td>${customer.Email}</td>
                    <td>${customer.PhoneNumber}</td>
                    <td>${customer.Address}</td>
                    <td>${customer.CreatedAt}</td>
                    <td>
                        <button class="edit" onClick="showEditCustomer(${customer.CustomerID})">Edit</button>
                        <button class="delete" onClick="deleteCustomer(${customer.CustomerID})">Delete</button>
                    </td>
                `;

                CustomersTable.appendChild(tr);
            });


        }
        catch (error) {
            console.log("Error from fech", error);
        }
    }
    // delete
    window.deleteCustomer = async (id) => {
        console.log("ID to delete:", id);

        if (confirm('คุณต้องการลบใช่ไหม ?')) {
            try {
                const res = await fetch(`${BASE_URL}/customer/${id}`, {
                    method: 'DELETE'
                })
                if (res.ok) {
                    fetchCustomers();
                }
            } catch (error) {
                console.log('Delete customer Error:', error);
            }
        }
    }

    const addCustomerFrom = document.getElementById("addCustomerFrom");
    addCustomerFrom.addEventListener('submit', async (event) => {
        event.preventDefault(); // ปกป้องการ refresh หน้าจอ
        // -- ดึงค่าจากหน้าจอ

        const FirstName = document.getElementById('firstName').value;
        const LastName = document.getElementById('lastName').value;
        const Email = document.getElementById('email').value;
        const PhoneNumber = document.getElementById('phone').value;
        const Address = document.getElementById('address').value;

        // console.log(title, author, published_date)
        try {
            const res = await fetch(`${BASE_URL}/customer`, {
                method: 'POST',
                headers: { 'content-type': 'application/json' },
                body: JSON.stringify({ FirstName, LastName, Email, PhoneNumber, Address })
            })

            if (res.ok) {
                fetchCustomers();
                addCustomerFrom.reset();
            }
        }
        catch {
            console.log('Error from insert customer', error)
        }
    });


    window.showEditCustomer = async (id) => {
        const editCustomerId = document.getElementById('editCustomerId');
        const eFirstName = document.getElementById('editFirstName');
        const eLastName = document.getElementById('editLastName');
        const eEmail = document.getElementById('editEmail');
        const ePhoneNumber = document.getElementById('editPhoneNumber');
        const eAddress = document.getElementById('editAddress');

        // -- get book by id 
        try {
            const res = await fetch(`${BASE_URL}/customer/${id}`);
            const customer = await res.json();
            customerOject = customer[0];

            if (customer) {
                editCustomerId.value = id;
                eFirstName.value = customerOject.FirstName;
                eLastName.value = customerOject.LastName;
                eEmail.value = customerOject.Email;
                ePhoneNumber.value = customerOject.PhoneNumber;
                eAddress.value = customerOject.Address;
                // Show the modal (assuming you have a function to show the modal)

                editWindow.style.display = 'block';
            } else {
                console.log('customer not found');
            }

        } catch (error) {
            console.log('Show Modal Error:', error);
        }
    }


    // -- update editCustomerForm
    const editCustomerForm = document.getElementById('editCustomerForm');
    console.log("Edit Customer Form:", editCustomerForm);

    editCustomerForm.addEventListener('submit', async (event) => {
        event.preventDefault();
        console.log("Edit Customer Form:", editCustomerForm);
        // console.log(eauthor.value);
        const CustomerId = document.getElementById('editCustomerId').value;
        const FirstName = document.getElementById('editFirstName').value;
        const LastName = document.getElementById('editLastName').value;
        const Email = document.getElementById('editEmail').value;
        const PhoneNumber = document.getElementById('editPhoneNumber').value;
        const Address = document.getElementById('editAddress').value;

        console.log(JSON.stringify({ FirstName, LastName, Email, PhoneNumber, Address }));

        try {
            const res = await fetch(`${BASE_URL}/customer/${CustomerId}`, {
                method: 'PUT',
                headers: {
                    'Content-type': 'application/json'
                },
                body: JSON.stringify({ FirstName, LastName, Email, PhoneNumber, Address})
            })
            if (res.ok) {
                fetchCustomers();
                closeModal();
            }
        } catch (error) {
            console.log('Update customer Error:', error);
        }
    })

    // -- ปิดหน้าต่าง
    window.closeModal = () => {
        editWindow.style.display = 'none';
    }

    fetchCustomers();

});
