import { StatusBar } from "expo-status-bar";
import React, {UseEffect, UseState } from "react";
import { ActivityIndicator, SafeAreaView, ScrollView, StyleSheet, Text, TextInput, 
    View, Button, Alert } from "react-native";

    
    export default function App() {
        
        const [ cep, alterarCep ] = React.useState("00000-000");
        const [ logradouro, alterarLogradouro ] = React.useState("");
        const [ numero, alterarNumero ] = React.useState("");
        const [ complemento, alterarComplemento ] = React.useState("");
        const [ bairro, alterarBairro ] = React.useState("");
        const [ cidade, alterarCidade ] = React.useState("");
        const [ estado, alterarEstado ] = React.useState("");

        return(
            <ScrollView>
                <SafeAreaView style = { styles.container }>

                    <View>
                        <Text style = { styles.text }>
                            ENDEREÇO
                        </Text>

                        <TextInput
                        style = { styles.input }
                        onChangeText = 
                        
                        />
                            
                    </View>

                </SafeAreaView>
            </ScrollView>
        )
    }