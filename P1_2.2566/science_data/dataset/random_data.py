import pandas as pd

titanic = pd.read_csv("train.csv")

#คำสั่งที่ใช้เพื่อแสดงข้อมูลแบบสุ่ม ด้วย .sample() :หมายเหตุ* ถ้าไม่ใส่ตัวเลข จะดึงมา 1 แถว
titanic_sample = titanic.sample(3)
print(titanic_sample)