# Despliegue

1. Ejecutar el comando para construir la imagen
   
   ```bash
    docker build -f ./empresa.webapi/Dockerfile -t registry.gitlab.com/iot.abx/empresa.webapi .
   ```

2. Subir la imagen al Container Registry de GitLab
   
   ```bash
   docker push registry.gitlab.com/iot.abx/empresa.webapi
   ```

3. Verificar que el archivo docker-compose este en el servidor

4. El archivo docker-compose debe estar para descargar la imagen. Comentar las siguientes lineas.
   
   ```yaml
       build:
         context: .
         dockerfile: conin.webapi/Dockerfile
   ```

5. Tener en cuenta lo siguiente:
   
   - Si es la primera vez que se va a desplegar el contenedor. Es decir no existe la imagen en el servidor. Ejectuar los siguientes comandos
   
   ```bash
   docker-compose pull & docker-compose up -d
   ```
   
   - Si la imagen ya existe en el servidor, pero el contenedor ha estado detenido y solo se va a volver a desplegar. Ejecutar el siguiente comando
   
   ```bash
   docker-compose up -d
   ```
   
   - Si se va a descargar una actualización del contenedor. Ejecutar los siguientes comandos
   
   ```bash
   docker-compose stop && docker-compose rm -f && docker-compose pull && docker-compose up -d
   ```
