

# Documentação referente as calsses Abstartas.

## Usando e implementando classes abstratas
* Antes de olharmos as  classes abstratas,
 primeiro precisamos dar uma olhada no modificador abstract e o que isso significa.
 O modificador abstrato simplesmente informa que a coisa que está sendo modificada não possui uma implementação completa. Este modificador pode ser usado com

* Classes

* Métodos

* Propriedades

* Indexadores

Quando usamos o modificador abstrato em uma declaração de classe,
na verdade estamos dizendo que a classe que estamos criando
é apenas a classe base básica de outras classes.

Isso significa que quaisquer membros marcados
como abstratos ou incluídos na classe base devem ser implementados
pelas classes derivadas (classes que usam a classe base). 
Você também ouvirá que as classes abstratas 
também são chamadas de blueprints.


## Recursos de classe abstrata
### As Classes  abstratas  têm as seguintes características importantes :
* Você não pode criar uma instância de uma classe abstrata.

* Uma classe abstrata pode conter métodos e acessadores abstratos.

*  não pode usar o modificador sealed com classes abstratas.

* Se uma classe não abstrata for derivada de uma classe abstrata, a classe derivada deverá incluir as implementações dos métodos e acessadores abstratos


#### A razão pela qual o modificador sealed não pode ser usado com uma classe abstrata é porque o modificador sealed impede a herança de classe, enquanto o modificador abstrato exige que uma classe seja herdada.


# Métodos abstratos

 > ####  O uso do modificador abstrato em um método ou declaração de propriedade simplesmente :
* O método abstrato é implicitamente um método virtual.

* Você só pode usar métodos abstratos em classes abstratas.

* Métodos abstratos não possuem implementação; portanto, não tem corpo de método.

* Você não tem permissão para usar os modificadores estáticos ou virtuais em uma declaração de método abstrato.

### O que queremos dizer quando falamos que um método abstrato não tem implementação e, portanto, nenhum corpo de método? Considere a listagem de código a seguir.
* Exemplo:  public abstract void MyAbstractMethod();
 * Acima declaramos um método abstrato.
* Isso basicamente nos diz que a classe que herdar essa classe base, precisá implementar esse método, e fornecer toda a implementação devida.

# Propriedades abstratas
> ####  pensando em métodos abstratos , você notará que as propriedades abstratas se comportam de maneira bastante semelhante.
* A diferença real está na sintaxe de declaração e invocação:
* Você não pode usar o modificador abstrato em uma propriedade estática.

* Você pode substituir a propriedade abstrata herdada na classe derivada declarando uma propriedade que usa o modificador de substituição .

Tudo isso fará mais sentido ao observar alguns exemplos de código. Vamos ilustrar o uso de classes abstratas a seguir.