<section align="center">
  
  <a href="https://i.ibb.co/g3BC3Zm/Gestin.jpg" target="_blank"><img src="https://i.ibb.co/g3BC3Zm/Gestin.jpg" alt="Gestin_Logo"></a>
  
   <img src="https://img.shields.io/badge/ESTADO-EN%20DESAROLLO-green" alt="Estado del Proyecto">
</section>


# Índice
- [Sobre Gestin :mag_right:](#sobre-gestin-mag_right)

- Acceso al proyecto :open_file_folder:
    - [Programas necesarios :dvd:](#white_check_mark-programas-necesarios-dvd)
    - [Clonar proyecto desde el repositorio :chart:](#white_check_mark-clonar-proyecto-desde-el-repositorio-en-gitlab-chart)
    - [Crear/Actualizar la base de datos :computer:](#white_check_mark-crearactualizar-la-base-de-datos-computer)
    - [Ejecutar el proyecto](#en-la-misma-terminal-ejecutar-el-proyecto-con-el-comando)

- [Restaurar Backup :cd:](#restaurar-backup-cd)
- [Tecnologías utilizadas :iphone:](#tecnologías-utilizadas-iphone)

- [Autores y Reconocimientos :mortar_board:](#autores-y-reconocimientos-mortar_board)


## Sobre Gestin :mag_right:

<p align="justify">
Gestin es un sistema de administración para institutos superiores de la provincia de Buenos Aires desarrollado por estudiantes del tercer año de la carrera de Técnico Superior en Análisis, Desarrollo y Programación de Aplicaciones del ISFT N° 194 de la ciudad de Miramar, partido de General Alvarado. Su desarrollo inició a principios del año 2022 y pretende ser un software de código abierto. 
</p>


## Acceso al proyecto :open_file_folder:
 ### :white_check_mark: `Programas necesarios` :dvd:
- Descargar e Instalar :arrow_down_small:
  - <a href="https://nodejs.org/es/download" target="_blank"> 
        Node.js [No es necesario]
    </a>    
  - <a href="https://dotnet.microsoft.com/es-es/download/dotnet/8.0" target="_blank"> 
        .NET 8.0
    </a> 
  - <a href="https://visualstudio.microsoft.com/es/downloads/" target="_blank"> 
        Visual Studio Community
    </a> 
  - <a href="https://www.microsoft.com/es-ar/sql-server/sql-server-downloads" target="_blank"> 
        SQL Server
    </a> 
  - <a href="https://learn.microsoft.com/es-es/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16" target="_blank"> 
        SQL Server Management Studio (SSMS)
    </a>
  - <a href="https://git-scm.com/downloads" target="_blank"> 
        Git
    </a>:point_right:<a href="https://git-scm.com/book/es/v2/Inicio---Sobre-el-Control-de-Versiones-Configurando-Git-por-primera-vez" target="_blank"> 
        (configurar Git)
    </a>
  - Entity Framework :point_right: ejecutar el siguiente comando en una nueva <a href="https://www.downloadsource.es/uploaded/News%20July%202015/Simbolo%20del%20sistema%20Como%20administrador/simbolo%20del%20sistema%20Windows%2010.jpg" target="_blank">terminal</a>:
    ```bash
    dotnet tool install --global dotnet-ef
    ```
  - EntityFrameworkCore.Design :point_right:
    ```bash
    dotnet add package Microsoft.EntityFrameworkCore.Design
    ```
  - EntityFrameworkCore.SQLServer :point_right:
    ```bash
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    ```
  - EntityFrameworkCore.Tools :point_right:
    ```bash
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    ```

 ### :white_check_mark: `Clonar proyecto desde el repositorio en GitLab` :chart:
- <a href="https://gitlab.com/gmauro2010/Gestin" target="_blank"> Repositorio (Gestin) en GitLab </a>
- Crear una nueva carpeta en nuestra PC, abrirla y luego :point_right: click derecho <a href="https://docs.github.com/es/repositories/creating-and-managing-repositories/cloning-a-repository" target="_blank"> Git Bash Here </a> y ejecutar el siguiente comando: 
    ```bash
    git clone https://gitlab.com/gmauro2010/Gestin.git
    ```

### :white_check_mark: `Crear/Actualizar la base de datos` :computer:
- Abrir la carpeta creada anteriormente, en donde se clonó el proyecto
- Buscar el archivo Gestin.sln y abrirlo con Visual Studio Community
- <a href="https://damiandeluca.com.ar/como-usar-la-terminal-integrada-de-visual-studio-code" target="_blank">Abrir una nueva terminal desde el Visual Studio</a>, de esta manera guarda la ubicación del proyecto, y ejecutar el siguiente comando:
  ```bash
  dotnet ef database update
  ```
- #### En la misma terminal, ejecutar el proyecto con el comando: 
   ```bash
   dotnet run
   ```

## Restaurar Backup :cd:
- <a href="https://drive.google.com/drive/folders/1gJ_BBtcXzaP8j2997JmKHiUiIXkRanhk" target="_blank">Descargar el último backup subido, el más reciente (archivo .bak)</a>
- Ir a la siguiente ubicación: 
  ```bash
   C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup
  ```
- Pegar el archivo .bak, descargado anteriormente, en esa ubicación
- Abrir el SQL Server Management Studio (SSMS)
- Establecer una conexión 
- Click derecho en Databases :point_right: <a href="https://www.ibm.com/docs/es/license-metric-tool?topic=database-restoring-sql-server" target="_blank">Restore Database</a>


## Tecnologías utilizadas :iphone:

<section align="center">
<a href="https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/" target="_blank"> <img src="https://play-lh.googleusercontent.com/uGqP7F-E_eaEwTb3hMz63MWf0YKRSK6n9INBwibBSOrGDg6B3sd-ACuqNrR312ohdQ" alt="c#" width="80" height="80"/> </a> :space_invader:
<a href="https://dotnet.microsoft.com/es-es/learn/dotnet/what-is-dotnet" target="_blank"> <img class="img" src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Microsoft_.NET_logo.svg/2048px-Microsoft_.NET_logo.svg.png" alt=".net" width="80" height="80"/> </a> :floppy_disk:
<a href="https://learn.microsoft.com/es-es/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries" target="_blank"> <img class="img" src="https://www.traininginchennai.in/contact/images/LINQ-greens.png" alt="linq" width="80" height="80"/> </a>
</section>



## Autores y reconocimientos :mortar_board:
| [<img src="https://gitlab.com/uploads/-/system/user/avatar/5414462/avatar.png?width=96" width=115><br><sub>Mauro Gómez</sub>](https://gitlab.com/gmauro2010) |  [<img src="https://secure.gravatar.com/avatar/38d15da39abbaee7d3a0721fb575f32a?s=192&d=identicon" width=115><br><sub>Facundo Narvaiz</sub>](https://gitlab.com/facundonarvaiz232) |  [<img src="https://gitlab.com/uploads/-/system/user/avatar/11519808/avatar.png?width=96" width=115><br><sub>Brian Lacassagne</sub>](https://gitlab.com/lacassagnebrian) |  [<img src="https://secure.gravatar.com/avatar/50cbdbd2598713dc0bd0461552cea78f?s=192&d=identicon" width=115><br><sub>Rafael Viau</sub>](https://gitlab.com/rafael_rodriguez_viau) | [<img src="https://secure.gravatar.com/avatar/c45b83d3e4ac34502737ca430eb9b1c6?s=192&d=identicon" width=115><br><sub>Ulises Basualdo</sub>](https://gitlab.com/ulimiramar) | [<img src="https://secure.gravatar.com/avatar/5912b6bb83ae2a340539818975e7a4e6?s=192&d=identicon" width=115><br><sub>Romina Carabajal</sub>](https://gitlab.com/romicarabajal1998) | [<img src="https://secure.gravatar.com/avatar/0375349f1362b2ce088fcc31e2fc0786?s=192&d=identicon" width=115><br><sub> Alan Dono</sub>](https://gitlab.com/Alan-Dono1) | [<img src="https://secure.gravatar.com/avatar/e28847fa2390e911bd6d5eaa2f965dbf?s=192&d=identicon" width=115><br><sub>Paola Galacho</sub>](https://gitlab.com/paocone) 
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | 
[<img src="https://i.pinimg.com/564x/59/29/a9/5929a9d05cc313f66db7a30f79d9fa1f.jpg" width=115><br><sub>Ana Juarez</sub>](https://github.com/manita02) |  [<img src="https://secure.gravatar.com/avatar/2d8bb96d80f9e98f8813621bee97c87a?s=192&d=identicon" width=115><br><sub>Martin Lopez</sub>](https://gitlab.com/martin.sergio.lopez) | [<img src="https://secure.gravatar.com/avatar/d3563e853cdc6b6984134f715701a56b?s=192&d=identicon" width=115><br><sub>Alfredo Magariños</sub>](https://gitlab.com/khruner) | [<img src="https://secure.gravatar.com/avatar/60459e1b95de84ff19a3d8d043ea340e?s=192&d=identicon" width=115><br><sub>Milena Mosquera</sub>](https://gitlab.com/milena031088) | [<img src="https://secure.gravatar.com/avatar/a83b45cc6306bf789401549b50f9b260?s=192&d=identicon" width=115><br><sub>Santiago Strano</sub>](https://gitlab.com/santiago.str1996) |  [<img src="https://gravatar.com/avatar/29fb24fc1783b0f219d6056f1d736293?size=256&d=identicon" width=115><br><sub>Maximiliano Romero</sub>](https://gitlab.com/maximilianoromerovigo) | [<img src="https://gitlab.com/uploads/-/system/user/avatar/12698131/avatar.png?width=800" width=115><br><sub>Francisco Galea</sub>](https://github.com/Francisco-Galea)
