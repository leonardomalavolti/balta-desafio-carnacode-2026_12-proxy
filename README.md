![ES-7](https://github.com/user-attachments/assets/61d1998c-69c4-484e-a6d8-7c84b03357b9)

## 🥁 CarnaCode 2026 - Desafio 12 - Proxy

Oi, eu sou o Leonardo Malavolti e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

---

## 🎯 Sobre este desafio

No desafio **Proxy** eu precisei resolver um problema real aplicando o **Design Pattern Proxy** para desacoplar responsabilidades e organizar melhor o sistema.

Neste processo eu pratiquei:

* ✅ Boas Práticas de Software  
* ✅ Código Limpo  
* ✅ SOLID  
* ✅ Design Patterns (Padrões de Projeto)  
* ✅ Separação de responsabilidades  

---

## 🚨 Problema

Uma aplicação corporativa precisava:

- Controlar acesso a documentos sensíveis
- Implementar cache para documentos pesados
- Registrar auditoria de todas as operações
- Evitar criação desnecessária de conexões custosas

O problema é que o código original:

- ❌ Misturava lógica de negócio com segurança
- ❌ Implementava cache manualmente
- ❌ Espalhava auditoria pelo código
- ❌ Criava o repositório mesmo sem necessidade (sem lazy loading)
- ❌ Possuía código duplicado
- ❌ Era difícil de estender

---

## 🧠 Solução com Proxy

A solução foi aplicar o **Proxy Pattern**, criando um objeto intermediário responsável por:

- 🔐 Controlar o acesso aos documentos
- 🗂️ Gerenciar cache
- 📋 Centralizar auditoria
- ⚡ Implementar lazy loading do repositório real

Com isso:

- O cliente não conhece mais detalhes internos
- O controle de acesso ficou transparente
- O cache foi desacoplado
- A auditoria foi centralizada
- O sistema ficou extensível (ex: rate limiting no futuro)

---

## 🏗 Estrutura da Solução

- `IDocumentService` → Interface comum
- `DocumentRepository` → Objeto real
- `DocumentProxy` → Proxy responsável por segurança, cache e auditoria
- `ConfidentialDocument` → Entidade
- `User` → Usuário com nível de permissão

---

## 🚀 Benefícios alcançados

✔ Separação clara de responsabilidades  
✔ Código mais organizado  
✔ Menor acoplamento  
✔ Extensível sem modificar o código original  
✔ Aplicação prática de SOLID  
✔ Implementação de Lazy Loading  

---

## 📚 Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais.

Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na identificação de códigos não escaláveis e na solução de problemas utilizando padrões amplamente utilizados no mercado.

---

## 📖 eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito:

👉 https://lp.balta.io/ebook-fundamentos-design-patterns

---

## 🔗 Veja meu progresso no desafio

[Incluir link para o repositório central]

---

🎭 Desafio 12/23 concluído!
