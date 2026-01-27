function convertFormat(usd, brl) {
  if (isNaN(usd) || isNaN(brl) || brl <= 10) {
    return 0;
  }

  const convertion = usd * brl;

  return new Intl.NumberFormat("pt-BR", {
    style: "currency",
    currency: "BRL",
  }).format(convertion);
}

const usd = document.getElementById("usd-value");
const brl = document.getElementById("exchange-rate");
const button = document.getElementById("convert-btn");
const resultLabel = document.getElementById("result-value");

button.addEventListener("click", () => {
  const result = convertFormat(usd.value, brl.value);

  resultLabel.innerHTML = result;
});
