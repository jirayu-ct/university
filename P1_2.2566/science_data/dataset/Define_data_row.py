import pandas as pd

titanic = pd.read_csv("train.csv")

#กำหนดจำนวนแถว x ที่ต้องการให้ดึงออกมา ด้วย .head(x) ถ้าไม่มี x จะแสดงมา 5 แถว
titanic_head = titanic.head()

print(titanic_head)


#กำหนดจำนวนแถวสุดท้าย x ที่ต้องการให้ดึงออกมา ด้วย .tail(x) ถ้าไม่มี x จะแสดงมา 5 แถว
titanic_tail = titanic.tail()
print(titanic_tail)