import pandas as pd

titanic = pd.read_csv("train.csv")

#ดูค่าทางสถิติของข้อมูล titanic.describe()
titanic_describe = titanic.describe()
print(titanic_describe)