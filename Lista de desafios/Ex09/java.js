function Formulario() {
      var senha = document.getElementById("senha").value;
      var confirmarSenha = document.getElementById("confirmarSenha").value;

      if (senha.length < 6 || senha.length > 10) {
        alert("A senha deve ter entre 6 e 10 caracteres.");
        return;
      }

      if (senha !== confirmarSenha) {
        alert("As senhas precisam ser iguais.");
        return;
      }
      
      alert("Cadastro concluído!");
    }