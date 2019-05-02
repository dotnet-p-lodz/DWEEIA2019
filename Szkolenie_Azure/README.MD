# Microsoft Azure - przyziemnie o usługach w chmurze
Materiały z prelekcji dot. Microsoft Azure.

## Przykładowe aplikacje

### **Static website**
Pliki strony należy jedynie wrzucić do Storage Account utworzonego na Azurze. Najlepiej wykorzystać w tym celu [Microsoft Azure Storage Explorer](https://azure.microsoft.com/en-us/features/storage-explorer/)

### **Redirect**
Aplikacja wymaga zmian dat, aby zobaczyć jej działanie. Odpowiednie (przyszłe) daty należy podawać w funkcji `Redirect.Helpers.GetData()`, linijki 31, 35 oraz 39.
<br/>**Uwaga!** Ze względu na cache'owanie informacji przez przeglądarki, przy testowaniu najlepiej korzystać z trybu incognito.

### **[Face API](https://docs.microsoft.com/en-us/azure/cognitive-services/face/quickstarts/csharp)**
Aby odpalić aplikację należy podać klucz subskrypcji w zmiennej `subscriptionKey` (12. linijka) oraz endpoint do serwisu w zmiennej `uriBase`.
<br/>Załączone są również 3 zdjęcia testowe. Po odpaleniu aplikacji można ich użyć podając 
- `images/face1.jpg`
- `images/face2.jpg`
- `images/face3.jpg`



## Przydatne linki:
- [Nagranie prelekcji](https://www.youtube.com/watch?v=RNCKzq3n9b4)
- [darmowa subskrypcja Azure dla studentów](https://azure.microsoft.com/en-us/free/students/)
- [darmowa subskrypcja Azure dla uczniów](https://azure.microsoft.com/en-us/offers/ms-azr-0144p/)
- [Microsoft Learn](https://docs.microsoft.com/en-us/learn/)
- Intelligent Kiosk - [aplikacja](https://www.microsoft.com/en-us/p/intelligent-kiosk/9nblggh5qd84),  [kod źródłowy](https://github.com/Microsoft/Cognitive-Samples-IntelligentKiosk)
