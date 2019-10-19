//variaveis globais
const addCurrencyBtn = document.querySelector(".add-currency-btn");
const addCurrencyList = document.querySelector(".add-currency-list");
const currenciesList = document.querySelector(".currencies");
const initialllyDisplayedCurrencies = ["USD", "EUR", "BRL", "CAD", "RUB"];
let baseCurrency;
let baseCurrencyAmount;

const currencies = [{

        name: "US Dollar",
        abbreviation: "USD",
        symbol: "\u0024",
        flagURL: "https://www.geonames.org/flags/l/us.gif",
        rate: 4.3330
    },
    {

        name: "Euro",
        abbreviation: "EUR",
        symbol: "\u20AC",
        flagURL: "https://upload.wikimedia.org/wikipedia/commons/b/b7/Flag_of_Europe.svg",
        rate: 4.3330
    },
    {

        name: "Japanese Yen",
        abbreviation: "JPY",
        symbol: "\u00A5",
        flagURL: "https://www.geonames.org/flags/l/jp.gif",
        rate: 4.3330
    },
    {

        name: "British Pound",
        abbreviation: "GBP",
        symbol: "\u00A3",
        flagURL: "http://www.geonames.org/flags/l/uk.gif",
        rate: 4.3330
    },
    {
        name: "Australian Dollar",
        abbreviation: "AUD",
        symbol: "\u0024",
        flagURL: "http://www.geonames.org/flags/l/au.gif",
        rate: 4.3330
    },
    {
        name: "Canadian Dollar",
        abbreviation: "CAD",
        symbol: "\u0024",
        flagURL: "http://www.geonames.org/flags/l/ca.gif",
        rate: 4.3330
    },
    {
        name: "Swiss Franc",
        abbreviation: "CHF",
        symbol: "\u0043\u0048\u0046",
        flagURL: "http://www.geonames.org/flags/l/ch.gif",
        rate: 4.3330
    },
    {
        name: "Chinese Yuan Renminbi",
        abbreviation: "CNY",
        symbol: "\u00A5",
        flagURL: "http://www.geonames.org/flags/l/cn.gif",
        rate: 4.3330
    },
    {
        name: "Swedish Krona",
        abbreviation: "SEK",
        symbol: "\u006B\u0072",
        flagURL: "http://www.geonames.org/flags/l/se.gif",
        rate: 4.3330
    },
    {
        name: "New Zealand Dollar",
        abbreviation: "NZD",
        symbol: "\u0024",
        flagURL: "http://www.geonames.org/flags/l/nz.gif",
        rate: 4.3330
    },
    {
        name: "Mexican Peso",
        abbreviation: "MXN",
        symbol: "\u0024",
        flagURL: "http://www.geonames.org/flags/l/mx.gif",
        rate: 4.3330
    },
    {
        name: "Singapore Dollar",
        abbreviation: "SGD",
        symbol: "\u0024",
        flagURL: "http://www.geonames.org/flags/l/sg.gif",
        rate: 4.3330
    },
    {
        name: "Hong Kong Dollar",
        abbreviation: "HKD",
        symbol: "\u0024",
        flagURL: "http://www.geonames.org/flags/l/hk.gif",
        rate: 4.3330
    },
    {
        name: "Norwegian Krone",
        abbreviation: "NOK",
        symbol: "\u006B\u0072",
        flagURL: "http://www.geonames.org/flags/l/no.gif",
        rate: 4.3330
    },
    {
        name: "South Korean Won",
        abbreviation: "KRW",
        symbol: "\u20A9",
        flagURL: "http://www.geonames.org/flags/l/kr.gif",
        rate: 4.3330
    },
    {
        name: "Turkish Lira",
        abbreviation: "TRY",
        symbol: "\u20BA",
        flagURL: "http://www.geonames.org/flags/l/tr.gif",
        rate: 4.3330
    },
    {
        name: "Russian Ruble",
        abbreviation: "RUB",
        symbol: "\u20BD",
        flagURL: "http://www.geonames.org/flags/l/ru.gif",
        rate: 4.3330
    },
    {
        name: "Indian Rupee",
        abbreviation: "INR",
        symbol: "\u20B9",
        flagURL: "http://www.geonames.org/flags/l/in.gif",
        rate: 4.3330
    },
    {
        name: "Brazilian Real",
        abbreviation: "BRL",
        symbol: "\u0052\u0024",
        flagURL: "http://www.geonames.org/flags/l/br.gif",
        rate: 4.3330
    },
    {
        name: "South African Rand",
        abbreviation: "ZAR",
        symbol: "\u0052",
        flagURL: "http://www.geonames.org/flags/l/za.gif",
        rate: 4.3330
    },
    {
        name: "Philippine Peso",
        abbreviation: "PHP",
        symbol: "\u20B1",
        flagURL: "http://www.geonames.org/flags/l/ph.gif",
        rate: 4.3330
    },
    {
        name: "Czech Koruna",
        abbreviation: "CZK",
        symbol: "\u004B\u010D",
        flagURL: "http://www.geonames.org/flags/l/cz.gif",
        rate: 4.3330
    },
    {
        name: "Indonesian Rupiah",
        abbreviation: "IDR",
        symbol: "\u0052\u0070",
        flagURL: "http://www.geonames.org/flags/l/id.gif",
        rate: 4.3330
    },
    {
        name: "Malaysian Ringgit",
        abbreviation: "MYR",
        symbol: "\u0052\u004D",
        flagURL: "http://www.geonames.org/flags/l/my.gif",
        rate: 4.3330
    },
    {
        name: "Hungarian Forint",
        abbreviation: "HUF",
        symbol: "\u0046\u0074",
        flagURL: "http://www.geonames.org/flags/l/hu.gif",
        rate: 4.3330
    },
    {
        name: "Icelandic Krona",
        abbreviation: "ISK",
        symbol: "\u006B\u0072",
        flagURL: "http://www.geonames.org/flags/l/is.gif",
        rate: 4.3330
    },
    {
        name: "Croatian Kuna",
        abbreviation: "HRK",
        symbol: "\u006B\u006E",
        flagURL: "http://www.geonames.org/flags/l/hr.gif",
        rate: 4.3330
    },
    {
        name: "Bulgarian Lev",
        abbreviation: "BGN",
        symbol: "\u043B\u0432",
        flagURL: "http://www.geonames.org/flags/l/bg.gif",
        rate: 4.3330
    },
    {
        name: "Romanian Leu",
        abbreviation: "RON",
        symbol: "\u006C\u0065\u0069",
        flagURL: "http://www.geonames.org/flags/l/ro.gif",
        rate: 4.3330
    },
    {
        name: "Danish Krone",
        abbreviation: "DKK",
        symbol: "\u006B\u0072",
        flagURL: "http://www.geonames.org/flags/l/dk.gif",
        rate: 4.3330
    },
    {
        name: "Thai Baht",
        abbreviation: "THB",
        symbol: "\u0E3F",
        flagURL: "http://www.geonames.org/flags/l/th.gif",
        rate: 4.3330
    },
    {
        name: "Polish Zloty",
        abbreviation: "PLN",
        symbol: "\u007A\u0142",
        flagURL: "http://www.geonames.org/flags/l/pl.gif",
        rate: 4.3330
    },
    {
        name: "Israeli Shekel",
        abbreviation: "ILS",
        symbol: "\u20AA",
        flagURL: "http://www.geonames.org/flags/l/il.gif",
        rate: 4.3330
    }

];

//evento click
addCurrencyBtn.addEventListener("click", addCurrencyBtnClick);

function addCurrencyBtnClick(event) {
    addCurrencyBtn.classList.toggle("open")
}
//funcoes auxiliares
function populateAddCurrencyList() {
    for (let i = 0; i < currencies.length; i++) {
        addCurrencyList.insertAdjacentHTML(
            "beforeend",
            `<li data-currency=${currencies[i].abbreviation}>
          <img src=${currencies[i].flagURL} class="flag"><span>${currencies[i].abbreviation} - ${currencies[i].name}</span>
        </li>`
        );
    }
}

function populateCurrenciesList() {
    for (let i = 0; i < initialllyDisplayedCurrencies.length; i++) {
        const currency = currencies.find(c => c.abbreviation === initialllyDisplayedCurrencies[i]);
        if (currency) newCurrenciesListItem(currency);
    }
}

function newCurrenciesListItem(currency) {
    if (currenciesList.childElementCount === 0) {
        baseCurrency = currency.abbreviation;
        baseCurrencyAmount = 0;
    }
    addCurrencyList.querySelector(`[data-currency=${currency.abbreviation}]`).classList.add("disabled");
    const baseCurrencyRate = currencies.find(c => c.abbreviation === baseCurrency).rate;
    const exchangeRate = currency.abbreviation === baseCurrency ? 1 : (currency.rate / baseCurrencyRate).toFixed(4);
    const inputValue = baseCurrencyAmount ? (baseCurrencyAmount * exchangeRate).toFixed(4) : "";
    currenciesList.insertAdjacentHTML(
        "beforeend",
        `<li class="currency ${currency.abbreviation===baseCurrency ? "base-currency" : ""}" id=${currency.abbreviation}>
      <img src=${currency.flagURL} class="flag">
      <div class="info">
        <p class="input"><span class="currency-symbol">${currency.symbol}</span><input placeholder="0.0000" value=${inputValue}></p>
        <p class="currency-name">${currency.abbreviation} - ${currency.name}</p>
        <p class="base-currency-rate">1 ${baseCurrency} = ${exchangeRate} ${currency.abbreviation}</p>
      </div>
      <span class="close">&times;</span>
    </li>`
    );
}
populateAddCurrencyList();

populateCurrenciesList();