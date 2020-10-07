# Python program to Find day of  
# the week for a given date
# cerner_2^5_2020 
import calendar 
  
def findDay(date): 
    day, month, year = (int(i) for i in date.split(' '))     
    dayNumber = calendar.weekday(year, month, day) 
    days =["Monday", "Tuesday", "Wednesday", "Thursday", 
                         "Friday", "Saturday", "Sunday"] 
    return (days[dayNumber]) 
  
# Driver program 
date = '03 02 2019'
print(findDay(date)) 