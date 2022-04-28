module com.example.library {
    requires javafx.controls;
    requires javafx.fxml;

    opens com.example.library to javafx.fxml;
    exports com.example.library;
    opens com.example.library.controllers to javafx.fxml;
    exports com.example.library.controllers;
}