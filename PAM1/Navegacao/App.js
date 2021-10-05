import * as React from "react";
import { Button, View, Text } from "react-native";
import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";

const JanelaInicial = ({ navigation }) => {
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text style={{paddingBottom: 50}}>Qual vc prefere?</Text>
      <Button title="L" onPress={()=> navigation.navigate ("L")}></Button>
      <Button title="KIRA" onPress={()=> navigation.navigate ("Kira")}></Button>
    </View>
  );
};

const Stack = createNativeStackNavigator();

const L = () => {
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text>Boa Escolha</Text>
    </View>
  );
};

const Kira = () => {
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text>Boa Escolha</Text>
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
        <Stack.Screen
          name="Kira"
          component={Kira}
        />
        <Stack.Screen
          name="L"
          component={L}
        />
      </Stack.Navigator>
    </NavigationContainer>
  );
};

export default App;
