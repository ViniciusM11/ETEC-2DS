import React from "react"; // importando a biblioteca React para
// habilitar o uso do JSX
// Importando componentes nativos Text e View do RN
import { Text, View, SafeAreaView, StyleSheet, TextInput } from "react-native";

// Declarando a função HelloWorldApp como um Componente Funcional
// Ele retorna uma View com uma Text dentro dela
// const HelloWorldApp = () => {
//   return (
//     <View // Cria um contêiner para agrupar objetos visuais
//     style = {styles.container}
// >
//       <Text>Hello, world!</Text>
//     </View>
//   );
// };

// const styles = StyleSheet.create({
//   container: {
//     // Responsável pelo estilo (aparência) do componente View
//     flex: 1, // preenche todo o espaço disponível
//     justifyContent: "center", // centraliza verticalmente os objetos internos
//     alignItems: "center", // centraliza horizontalmente os objetos internos
//     backgroundColor: "red",
//     padding: 50,
//     margin: 75,
//   },
//   imagem: {

//   }
// });

//export default HelloWorldApp; // Explode a aplicação na tela

const UselessTextInput = () => {
  const [text, onChangeText] = React.useState(null);
  const [number, onChangeNumber] = React.useState(null);
  
  return (
    <SafeAreaView>
      <TextInput
        style={styles.input}
        onChangeText={onChangeText}
        value={text}
        placeholder="Nome"
      />
      <TextInput
        style={styles.input}
        onChangeText={onChangeNumber}
        value={number}
        placeholder="Telefone"
        keyboardType="numeric"
      />
      <TextInput
        style={styles.input}
        onChangeText={onChangeNumber}
        value={number}
        placeholder="Idade"
        keyboardType="numeric"
      />
    </SafeAreaView>
  );
};
const styles = StyleSheet.create({
  input: {
    height: 40,
    margin: 50,
    borderWidth: 2,
    padding: 10,
  },

});

export default UselessTextInput;
