# 🏋️‍♂️ LifeStyle - Sistema para Academias

**LifeStyle** é um sistema desktop desenvolvido para academias com o objetivo de simplificar o gerenciamento de alunos, horários, professores, turmas e usuários administrativos. Construído com tecnologias leves e voltado para ambientes Windows, o sistema oferece uma solução eficiente e de fácil instalação.

## 🧰 Tecnologias Utilizadas

- 💻 **C#**
- 🔧 **.NET Framework 4.5**
- 🗄️ **SQLite** (banco de dados local, sem necessidade de servidor)

## 📂 Estrutura Principal do Banco de Dados

O banco de dados foi modelado em SQLite para garantir leveza, simplicidade e portabilidade. Abaixo, as principais tabelas e suas finalidades:

| Tabela       | Finalidade                                               |
|--------------|----------------------------------------------------------|
| **Alunos**       | Cadastro de alunos, dados pessoais, planos de matrícula |
| **Horarios**     | Definição dos horários disponíveis por turma e professor |
| **Professores**  | Cadastro de profissionais e especialidades            |
| **Turmas**       | Agrupamento de alunos por horários e professores       |
| **Usuarios**     | Gerenciamento dos acessos ao sistema (admin, operador) |

---
O banco de dados esta localizado em LifeStyle\bin\Debug\banco
---

## 🚀 Funcionalidades Principais

- Cadastro completo de alunos e professores
- Criação e gerenciamento de turmas
- Controle de horários e grade de aulas
- Sistema de login com níveis de acesso
- Interface intuitiva com foco em usabilidade

## 🖥️ Requisitos Mínimos

- Windows 7 ou superior
- .NET Framework 4.5 instalado
- Não requer servidor de banco de dados

## 📌 Observações

Este projeto foi desenvolvido com foco em uso local e offline, ideal para academias de pequeno a médio porte que buscam uma solução eficiente, de baixo custo e fácil manutenção.

---

