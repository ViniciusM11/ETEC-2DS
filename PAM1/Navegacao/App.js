import * as React from "react";
import { Image, StyleSheet, TouchableOpacity, Button, View, Text } from "react-native";
import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import LImg from "./assets/LImg.jpg";
import KImg from "./assets/KiraImg.jpg";



const JanelaInicial = ({ navigation }) => {
  return (
    <View style={styles.container}>
      <Text>Qual você prefere?</Text>
      <TouchableOpacity style={styles.botao} onPress={() => navigation.navigate("Lawliet")}>
        <Text style={styles.botao1}>L</Text>
      </TouchableOpacity>

      <TouchableOpacity style={styles.botao} onPress={() => navigation.navigate("Kira")}>
        <Text style={styles.botao1}>KIRA</Text>
      </TouchableOpacity>
    </View>
  );
};

const Stack = createNativeStackNavigator();

const Lawliet = () => {
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text style={{fontSize: 30}} >Boa Escolha</Text>
      <Image style={styles.img} source={LImg}></Image>
    </View>
  );
};

const Kira = () => {
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text style={{fontSize: 30}} >Boa Escolha</Text>
      <Image style={styles.img} source={KImg}></Image>
    </View>
  );
};

const App = () => {
  return (
    <NavigationContainer>
      <Stack.Navigator
        initialRouteName="Inicial"
        screenOptions={{ headerTitle: "?" }}
      >
        <Stack.Screen name="Inicial" component={JanelaInicial} />
        <Stack.Screen name="Kira" component={Kira} />
        <Stack.Screen name="Lawliet" component={Lawliet} />
      </Stack.Navigator>
    </NavigationContainer>
  );
};



const styles = StyleSheet.create({
  container: { 
    flex: 1, 
    alignItems: "center", 
    justifyContent: "center",
    padding: 55
  },

  botao: {
    padding: 5,
    width: 100,
    height: 50
  },

  botao1: {
    width: 100,
    height: 30,
    backgroundColor: '#7883FF',
    textAlign: "center"
    
  },

  img: {
    padding: 8,
    margin:48, 
    width: 400, 
    height:400
  }

});

export default App;
