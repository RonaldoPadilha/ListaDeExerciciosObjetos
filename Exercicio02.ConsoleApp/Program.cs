//2.Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
using Exercicio02.ConsoleApp;

TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();
fahrenheit.graus = 100;

TemperaturaCelsius celsius = fahrenheit.converterParaCelcius();

Console.WriteLine($"A conversão de {fahrenheit.graus} F resultou em: {celsius.graus:F1} C");