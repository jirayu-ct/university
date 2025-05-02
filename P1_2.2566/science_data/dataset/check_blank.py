import pandas as pd

titanic = pd.read_csv("train.csv")

#ตรวจสอบค่าว่าง titanic.isnull().sum()
titanic_isnull = titanic.isnull().sum()
print(titanic_isnull)