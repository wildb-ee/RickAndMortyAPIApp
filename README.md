# RickAndMortyAPIApp

#IN ORDER FOR IT TO WORK PROPERLY YOU NEED TO FIX THE ERROR WITH CHAIN OF RESPONSIBILITY (UNIT OF WORK GETS SERVICE PROVIDER DISPOSED IN ALL, BUT FIRST, HANDLERS)
#Через serviceProvider вызывайте функцию get service и там вызывайте generic IUnitOfWork в том месте где есть многопоточности

#ALSO, YOU NEED TO FIX ERROR WITH CHANGING THE NUMBERS OF AN API REQUESTS 
