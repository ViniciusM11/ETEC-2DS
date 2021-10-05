import { StatusBar } from "expo-status-bar";
import React, { UseEffect, UseState } from "react";
import {
  ActivityIndicator,
  SafeAreaView,
  ScrollView,
  StyleSheet,
  Text,
  TextInput,
  View,
  Button,
  Alert,
} from "react-native";

export default function App() {
  const [cep, alterarCep] = React.useState("");
  const [logradouro, alterarLogradouro] = React.useState("");
  const [numero, alterarNumero] = React.useState("");
  const [complemento, alterarComplemento] = React.useState("");
  const [bairro, alterarBairro] = React.useState("");
  const [cidade, alterarCidade] = React.useState("");
  const [estado, alterarEstado] = React.useState("");

  return (
    <ScrollView>
      <SafeAreaView style={styles.container}>
        <View>
          <Text style={styles.text}>ENDEREÇO</Text>

          <TextInput
            style={styles.input}
            onChangeText={alterarCep}
            value={cep}
            keyboardType="numeric"
            maxLength={9}
            placeholder={"CEP"}
          />

          <TextInput
            style={styles.input}
            onChangeText={alterarLogradouro}
            value={logradouro}
            keyboardType="default"
            hintText={"Logradouro"}
            placeholder={"Logradouro"}
          />

          <TextInput
            style={styles.input}
            onChangeText={alterarNumero}
            value={numero}
            keyboardType="numeric"
            maxLength={7}
            placeholder={"Número"}
          />

          <TextInput
            style={styles.input}
            onChangeText={alterarComplemento}
            value={complemento}
            keyboardType="default"
            placeholder={"Complemento"}
          />

          <TextInput
            style={styles.input}
            onChangeText={alterarBairro}
            value={bairro}
            keyboardType="default"
            placeholder={"Bairro"}
          />

          <TextInput
            style={styles.input}
            onChangeText={alterarCidade}
            value={cidade}
            keyboardType="default"
            placeholder={"Cidade"}
          />

          <TextInput
            style={styles.input}
            onChangeText={alterarEstado}
            value={estado}
            keyboardType="default"
            placeholder={"Estado"}
          />
        </View>
      </SafeAreaView>
    </ScrollView>
  );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "#fff",
        margin: 16,
        marginTop: 48,
    },

    text: {
        alignItems: "center",
        alignContent: "center",
        alignSelf: "center",
    },

    input: {
        height: 40,
        margin: 3,
        borderWidth: 1,
        padding: 1,
        width: "100%",
        justifyContent: "center",
        alignSelf: "center",
        maxWidth: 256,
    },
});
