import pandas as pd

titanic = pd.read_csv("train.csv")

#แทนที่ค่าว่างด้วยข้อมูลที่กำหนดด้วยฟังก์ชั่น fillna //มันจะแทนที่ค่าที่ว่างทั้งหมดในคอลั่มนั้นๆ
#ชื่อไฟล์.ชือคอลั่ม.fillna('ข้อมูลที่ตั้งการใส่', inplace=True)
titanic.Age.fillna(30, inplace=True)


# inplace=True จะแก้ไขข้อมูลใน Dataset เรา
# inplace=False จะไม่แก้ไขข้อมูลใน Dataset เรา
# ปกติถ้าเราไม่ใส่ inplace ในโค้ด จะมีค่าเป็น inplace=False 