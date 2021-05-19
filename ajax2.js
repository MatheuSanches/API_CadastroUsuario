$(document).ready(function(){
	$('#tabela').empty(); //Limpando a tabela
	$.ajax({
		type:'put',		//Definimos o método HTTP usado
        dataType: 'json',	//Definimos o tipo de retorno
        data:'',
		url: 'https://localhost:44322/api/Usuario',//Definindo o arquivo onde serão buscados os dados
		success: function(dados){
			for(var i=0;dados.length>i;i++){
				//Adicionando registros retornados na tabela <td>'+dados[i].Id+'</td>
				$('#tabela').append('<tr><td>'+dados[i].pes_codigo+
				'</td><td>'+dados[i].pes_endereco+'</td><td>'+dados[i].pes_telefone+
				'</td><td><input type="button" onclick="insereTexto2('+dados[i].pes_codigo+')" value="Editar Usuario"></td></tr>');
				
			}
		}
	});
});