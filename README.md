## Teste Prático | Analista Desenvolvedor .NET Core
E-turn practical test for back-end job apllication using .NET Core + ReactJS and Redux

> Para distribuição das palestras seguindo a orientação no documento de requisitos, envie uma requisição GET para a rota http://localhost:5000/api/lecturetrack/allocate

### Inputs

|           Title           | Duration |
| ------------------------- | -------- |
| Escrevendo testes rápidos |  60min   |
|   Uma visão sobre Python  |  45min   |
|           Angular         |  30min   |
| Otimizando aplicações com o NodeJS |  45min   |
| Erros comuns no desenvolvimento de software |  45min   |
| Rails para Desenvolvedores Python |  60min   |
| ASP.net MVC |  60min   |
| TDD na prática |  45min   |
| Woah |  30min   |
| Sente e escreva |  30min   |
| Pair Programming vs Noise |  45min   |
| Mobilidade em desenvolvimento |  60min   |
| Ruby on Rails: Por que devemos migrar para ele? |  60min   |
| Otimizando aplicações .NET |  45min   |
| Java e os novos paradigmas de programação |  30min   |
| Rubi vs. Clojure para Back-End |  30min   |
| Scrum para leigos |  60min   |
| Um mundo sem stackoverflow |  30min   |
| UX |  30min   |

### Outputs

|Time    |Title                                          |Duration|Track   |
|--------|-----------------------------------------------|--------|--------|
|09:00:00|Escrevendo testes rápidos                      |60m     |Trilha 1|
|10:00:00|Uma visão sobre Python                         |45m     |Trilha 1|
|10:45:00|Angular                                        |30m     |Trilha 1|
|11:15:00|Otimizando aplicações com o NodeJS             |45m     |Trilha 1|
|12:00:00|Almoço                                         |30m     |Trilha 1|
|13:00:00|Erros comuns no desenvolvimento de software    |45m     |Trilha 1|
|13:45:00|Rails para Desenvolvedores Python              |60m     |Trilha 1|
|14:45:00|ASP.net MV                                     |60m     |Trilha 1|
|15:45:00|TDD na prática                                 |45m     |Trilha 1|
|16:30:00|Woah                                           |30m     |Trilha 1|
|17:00:00|Evento de Networking                           |0m      |Trilha 1|
|09:00:00|Sente e escreva                                |30m     |Trilha 2|
|09:30:00|Pair Programming vs Noise                      |45m     |Trilha 2|
|10:15:00|Mobilidade em desenvolvimento                  |60m     |Trilha 2|
|11:15:00|Otimizando aplicações .NE                      |45m     |Trilha 2|
|12:00:00|Almoço                                         |30m     |Trilha 2|
|13:00:00|Ruby on Rails: Por que devemos migrar para ele?|60m     |Trilha 2|
|14:00:00|Java e os novos paradigmas de programação      |30m     |Trilha 2|
|14:30:00|Rubi vs. Clojure para Back-End                 |30m     |Trilha 2|
|15:00:00|Scrum para leigo                               |60m     |Trilha 2|
|16:00:00|Um mundo sem stackoverflow                     |30m     |Trilha 2|
|16:30:00|UX                                             |30m     |Trilha 2|
|17:00:00|Evento de Networking                           |0m      |Trilha 2|

### Routes

| URL                                             | Action | BODY                                      | Desription                                                                                                               |
|-------------------------------------------------|--------|-------------------------------------------|--------------------------------------------------------------------------------------------------------------------------|
| http://localhost:5000/api/lecture               | GET    | No Body                                   | Lista todas as palestras                                                                                                 |
| http://localhost:5000/api/lecture/{id}          | GET    | No Body                                   | Lista uma palestra pelo ID                                                                                               |
| http://localhost:5000/api/lecture               | POST   | {"title": "string","duration": "integer"} | Salva uma nova palestra                                                                                                  |
| http://localhost:5000/api/lecture/1             | PUT    | {"title": "string","duration": "integer"} | Atualiza uma palestra existente pelo ID                                                                                  |
| http://localhost:5000/api/lecture/1             | DELETE | No Body                                   | Exclui uma palestra pelo ID                                                                                              |
| http://localhost:5000/api/lecturetrack          | GET    | No Body                                   | Lista as palestras associadas a cada trilha                                                                              |
| http://localhost:5000/api/lecturetrack/allocate | GET    | No Body                                   | Distribui cada palestra em sua trilha correspondente, respeitando a regra de negócio descrita no documento de requisitos |
