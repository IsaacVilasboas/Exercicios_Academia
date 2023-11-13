    var fisica = document.getElementById('Fisica');
    var juridica = document.getElementById('Juridica');
    var cpf = document.getElementById('cpf');
    var cnpj = document.getElementById('cnpj');
    var data = document.getElementById('data');

    fisica.addEventListener('change', function() {
      cpf.disabled = !this.checked;
      data.disabled = !this.checked;
      cnpj.disabled = this.checked;
      if (this.checked) {
        cpf.setAttribute('required', '');
        data.setAttribute('required', '');
      } else {
        cpf.removeAttribute('required');
        data.removeAttribute('required');
      }
    });

    juridica.addEventListener('change', function() {
      cnpj.disabled = !this.checked;
      cpf.disabled = this.checked;
      data.disabled = this.checked;
      if (this.checked) {
        cnpj.setAttribute('required', '');
      } else {
        cnpj.removeAttribute('required');
      }
    });

    function Formulario(){

        alert("Cadastro concluido!");

    }
      
    
