# wpf-chart-demo
Przykład wyświetlenia wykresów w aplikacji WPF MVVM


## Instalacja biblioteki

~~~ bash
Install-Package WPFToolkit.DataVisualization
~~~

## Wyświetlenie wykresu

1. Dodaj namespace
~~~ xml
xmlns:dv="clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit"
~~~ 

2. Umieść wykres
~~~ xml
 <dv:Chart>
        <dv:Chart.Series>
            <dv:PieSeries Title="Experience"
                          ItemsSource="{Binding Summaries}"
                          DependentValuePath="Count" 
                          IndependentValuePath="Name">
            </dv:PieSeries>
        </dv:Chart.Series>
    </dv:Chart>

~~~            
