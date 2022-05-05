#Cargar un archivo


with open ("C:\\Users\\Alumno\\Desktop\\Laboratorio-OB-main\\Villalba_5_11\\santi.txt","r") as lean:
    lineas = lean.readlines()
    
    for i in lineas:
        for u in lineas:
            #print(i , u)
            i=int(i)
            u=int(u)
            if i+u == 2020:
                print(i*u)
            # else:
            #     print(i,u)

#print(lineas)

#una sola de estas barras va para atras
    
for i in lineas:
        for u in lineas:
            #print(i , u)
            i=int(i)
            u=int(u)
            if i+u == 2020:
                print(i*u)
            # else:
            #     print(i,u)

#print(lineas)

#una sola de estas barras \ va para atras