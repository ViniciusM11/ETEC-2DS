import React from "react";
import {
  View,
  Text,
  TextInput,
  Image,
  Button,
  TouchableOpacity,
} from "react-native";

const App = () => {
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text>Retomada de Conteúdo</Text>
      <Text>Nome:</Text>
      <TextInput
        maxLength={200}
        margin={5}
        padding={8}
        textAlign={"center"}
        style={{
          backgroundColor: "#F5F5F5",
          borderWidth: 2,
          borderRadius: 64,
          height: "9%",
          width: "90%",
        }}
      ></TextInput>
      <Button title="CADASTRAR"></Button>
    </View>
  );
};

export default App;
