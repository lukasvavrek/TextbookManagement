docker run -d `
  -p 3308:3306 `
  --name textbook-management-mariadb `
  --env MYSQL_ROOT_PASSWORD=root `
  mariadb:latest