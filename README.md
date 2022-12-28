
# Web-API Multitenant MySQL

Web-API desenvolvida em .Net Core + Entity Framework 6 + MYSQL utilizando o princípio de SaaS (Software as a Service) essa Web-API foi criada 
com o intuito de servir a um ERP que utiliza o padrão de Arquitetura Multitenant, onde cada empresa é um Tenant (Locatório) com suas strings de conexões distintas.



## Demonstração

https://static.imasters.com.br/wp-content/uploads/2018/06/19143947/TR.jpg


## Configurações de Conexões

No arquivo appsettings.json, abra-o e poderá definir o caminho da conexão a ser injetada.

  "ConnectionStrings": {
    "LTL": "Server=Trinity01;Database=ltlmontagens;uid=root;pwd=root;Port=3306;charset=utf8;"
    "TENANT": "Server=Trinity01;Database=ltlmontagens;uid=root;pwd=root;Port=3306;charset=utf8;"
  },

`TENANT` Você definirá as configurações de conexão da Tenant, vale ressaltar que esse nome será 
utilizado na novagação da rota da da API.


## Utilização da API

#### Retorna todos os itens

```http
  GET /{empresa}/Cliente
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `empresa` | `string` | **Obrigatório**. Tenant definido em appsettings.json |

#### Retorna uma lista de clientes especificos da Tenant.
