import React, { useState } from "react";
import { View, Text, Image, TouchableOpacity, TextInput } from "react-native";
import miranha from "./assets/R.jpg";

const App = () => {
  const [texto, setTexto] = useState("");
  const [textoDaNoite, setTextoDaNoite] = useState("Noite Quente!");

  return (
    <View
      focusable={false}
      style={{
        flex: 1,
        backgroundColor: "red",
        justifyContent: "center",
        alignItems: "center",
      }}
    >
      <Text
        style={{
          color: "white",
          fontWeight: "bold",
          fontSize: "28px",
        }}
      >
        {" "}
        {textoDaNoite}{" "}
      </Text>

      <Image
        source={miranha}
        style={{
          width: "100px",
          height: "100px",
        }}
      />

      <TouchableOpacity
        onPress={() => alert("Caverninha na área!")}
        style={{
          backgroundColor: "darkgreen",
          padding: "16px",
          margin: 48,
          borderRadius: 16,
        }}
      >
        <Text
          style={{
            color: "white",
          }}
        >
          {" "}
          CLIQUE AQUI{" "}
        </Text>{" "}
      </TouchableOpacity>

      <TextInput
        focusable={true}
        onChangeText={setTexto}
        style={{
          backgroundColor: "white",
          borderColor: "black",
          borderRadius: 16,
          fontFamily: "Time News Roman",
          fontSize: 24,
          padding: 8,
        }}
      />

      <TouchableOpacity
        onPress={() => {
          setTextoDaNoite(texto);
        }}
        style={{
          backgroundColor: "blue",
          padding: 8,
          marginTop: 8,
        }}
      >
        <Image
          source={{
            uri: "https://reactnative.dev/img/header_logo.svg",
          }}
          style={{
            width: 100,
            height: 100,
            padding: 8,
            marginHorizontal: 8,
          }}
        />{" "}
      </TouchableOpacity>
    </View>
  );
};

export default App;
