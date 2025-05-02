import pandas as pd

titanic = pd.read_csv("train.csv")

#ตรวจสอบจ านวนแถว และคอลัมภ์ของข้อมูล titanic.shape
titanic_shape = titanic.shape

print(titanic_shape)