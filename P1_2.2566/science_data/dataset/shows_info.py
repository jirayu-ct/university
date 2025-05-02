import pandas as pd

titanic = pd.read_csv("train.csv")


#info() : แสดงข้อมูลในภาพรวม
# เช่น ข้อมูลบาง column เป็นตัวเลข แต่อาจถูกเก็บเป็น string จึงต้องถูกแปลงก่อนที่จะเอามาบวกลบคูณหารได
titanic_info = titanic.info()
print(titanic_info)

