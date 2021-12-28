package Demo;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;

public class FX extends Application {
    @Override
    public void start(Stage stage) throws Exception {
        final StackPane root = new StackPane();
        final Scene scene = new Scene(root,1000,500);

        stage.setTitle("hello world");
        stage.setScene(scene);
        stage.show();
    }


    public static void main(String[] args) {
        launch(args);
    }
}
