# tpj2-base1

Implementar _keybind_ em um jogo tosquinho.

Deverá ser possível mudar, pelo inspector da unity, as teclas de ação do player **antes** do _play_.

Todas as definições de teclas devem ficar em um único script!

DICA: experimenta criar funções nesse script para cada ação do player.

Exemplo:
```csharp
public UnityEngine.KeyCode jumpKeyCode;

public bool GetJump()
{
  return UnityEngine.Input.GetKeyDown( jumpKeyCode );
}
```

**NÃO PRECISA MUDAR AS TECLAS ENQUANTO A UNITY TÁ EM _PLAY_!**

## Controles

- Mover para a direita
- Mover para a esquerda
- Pular
- Abaixar

## Extras

- Suporte a _gamepad_.
- Mais de uma tecla pra fazer a mesma função
  - `W` e `Espaço` fazem o personagem pular
- **Também** usar [essa biblioteca](https://github.com/JISyed/Unity-XboxCtrlrInput) pra pegar input do controle de XBox
  - https://github.com/JISyed/Unity-XboxCtrlrInput
- Teclado e Gamepad funcionam juntos
  - Tanto faz apertar `Espaço` ou o `X` do controle
- Fazer o controle tremer quando o personagem leva hit
  - Só da pra fazer usando bibliotecas externas de input (tipo essa de cima)

## Logística

- Grupos de 2 ou 3
- Enviar link do repositori por: https://goo.gl/forms/zkkwcGNANqPT4iLd2
