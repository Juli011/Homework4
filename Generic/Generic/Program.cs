using Generic.Model;

DatabaseEngine databaseEngine= new DatabaseEngine();
databaseEngine.WriteValue("table", PasswordGenerator.Generate());

