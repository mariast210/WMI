## Scripts

In the rppt directory, you can run:

`docker-compose up -d`

This will:

* download mongodb image, and start it up
* build and start backend under `WMI-Backend/WMI-Backend` folder using `Dockerfile`
* build and start frontend under `WMI-Frontend` folder using `Dockerfile`

How to access services:

* API Swagger Doc is accessible via `http://localhost:5001/swagger`
* Frontend is accessible via: `http://localhost:8080`
* MonogDB is accessible via `27018` port.
