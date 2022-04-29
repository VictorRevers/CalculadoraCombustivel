# CalculadoraCombustivel
Calculadora de combustivel com Windows Form .NET C#

# Exercicio:
Calcular a quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 12 km por litro. 
Para o cálculo, o usuário deve fornecer o tempo gas- to na viagem e a velocidade média. 
Dessa forma, é possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. 
Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula LITROS_USADOS = DISTANCIA / 12. 
O programa deve apresentar os valores da velocidade média, o tempo gasto, a distância percorrida e a quantidade de litros utiliza- da na viagem. 
Sugestão: trabalhe com valores reais.

# Arquivo com as funcionalidades:
https://github.com/VictorRevers/CalculadoraCombustivel/blob/master/CalculadoraCombustivel/Form1.cs

```
 public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tempo_gasto = float.Parse(textBox1.Text);
            float velocidade_media = float.Parse(textBox2.Text);

            float distancia = tempo_gasto * velocidade_media;
            float litros_usados = distancia / 12;

            richTextBox1.Text = "Tempo gasto(h): " + tempo_gasto +
                                "\nVelocidade media(km/h): " + velocidade_media +
                                "\nDistancia percorrida(km): " + distancia +
                                "\nListros Usados(L/km): " + litros_usados;
        }
```
# Formulário Executado:
![image](https://user-images.githubusercontent.com/60626825/165997141-5753be7d-825e-48e4-ad4d-3217592c620c.png)


