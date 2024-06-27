document.addEventListener("DOMContentLoaded", function() {
  const form = document.getElementById('calculatorForm');
  const resultDiv = document.getElementById('result');

  form.addEventListener('submit', function(event) {
    event.preventDefault(); 

    const minutes = parseFloat(document.getElementById('minutes').value);
    const sms = parseFloat(document.getElementById('sms').value);
    const data = parseFloat(document.getElementById('data').value);
    const operator = document.getElementById('operator').value;
    const tariff = document.getElementById('tariff').value;

    const totalCost = calculateCost(minutes, sms, data);

    resultDiv.innerHTML = `
      <h2>Результаты расчета</h2>
      <p><strong>Оператор связи:</strong> ${operator}</p>
      <p><strong>Выбранный тариф:</strong> ${tariff}</p>
      <p><strong>Количество минут:</strong> ${minutes}</p>
      <p><strong>Количество SMS:</strong> ${sms}</p>
      <p><strong>Объем интернет-трафика (ГБ):</strong> ${data}</p>
      <p><strong>Итоговая стоимость:</strong> ${totalCost} рублей</p>
    `;
  });

  function calculateCost(minutes, sms, data) {
    const costPerMinute = 0.5; 
    const costPerSMS = 1.0;    
    const costPerGB = 15.0;    

    const totalCost = minutes * costPerMinute + sms * costPerSMS + data * costPerGB;
    return totalCost.toFixed(2); 
  }
});
