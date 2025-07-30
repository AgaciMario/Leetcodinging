## Soma dupla (Two Sum)

#### Descrição

Dado um vetor nums e um inteiro target, retorne os indíces de dois números existentes dentro do vetor nums, de forma que a soma desses dois números seja igual ao número target.

Podemos assumir que cada input terá apenas uma solução, e não podemos utilziar o mesmo elemento duas vezes.

Exemplo 1:

Input: ``nums = [2,7,11,15], target = 9 ``
Output: ``[0,1]``
Explicação: como ``nums[0] + nums[1] == 9``, retornamos ``[0, 1]``.


### Solução força bruta

Iterar pelo array utilizando loops aninhados para realizar a validação de todas os pares possíveis até achar o que a soma é igual ao target.

Complexidade temporal: o(n^2)
Complexidade espacial: o(1)

### Solução otima

A Solução ótima para esse problema é mapear o array para uma hash table, dessa forma podemos dividir a implementação em dois loops independentes um deles realizara o mapeamento do array para uma hash table e o outro é utilizado apenas um para realizar a validação dos pares.

A ideia de resolução para esse problema especifico, é salvar os valores do array como chaves e os indíces como valores, dessa forma podemos computar a diferença entre o valor de nums``[i]`` com o target, e utilizar essa diferença como chave para busca dentro da hash table, caso essa chave exista podemos retornar o indice do item encontrado na hashtable e do indíce atual do for.

Resumindo: A diferenaça de nums``[i]`` e target é exatamente o número que precisamos para que o nosso nums``[i]`` chegue ao mesmo valor de target, assim se esse valor existir na hash tabela basta então retornar o valor do indíce atual i e o valor encontrado na tabela hash.

Complexidade temporal: o(n)
Complexidade espacial: o(n)

Nota: Essa ténica de mapear dados para uma hashtable pode ser usada em qualquer algoritimo que tenha complexidade temporal o(n^2) e complexidade espacial o(1) 
