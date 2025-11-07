using UnityEngine;

public class ValidateDirty : Validator
{
    protected override void ValidateCards()
    {
        if (PlayerCardManager.Instance.SelectedCards.Count == 1)
        {
            _isValid = false;
            return;
        }

        _isValid = SuitRules.AreEqual(_cardHolder.PCardScripts[0].Card.suit, _cardHolder.PCardScripts[_cardHolder.PCardScripts.Count - 1].Card.suit); 

        for (int i = 0; i < _cardHolder.PCardScripts.Count - 1; i++)
        {
            if (_cardHolder.PCardScripts[i].Card.suit == Suits.Joker)
            {
                _isValid = true;
                continue;
            }

            if (!_isValid) break;

            _isValid = SuitRules.AreEqual(_cardHolder.PCardScripts[i].Card.suit, _cardHolder.PCardScripts[i + 1].Card.suit); // changed == for SuitRules. It works the same way as "==" but let relics easly change logic

            if (!_isValid) break;

            _isValid = _cardHolder.PCardScripts[i].Card.power + 1 == _cardHolder.PCardScripts[i + 1].Card.power;
            if (_cardHolder.PCardScripts[i + 1].Card.suit == Suits.Joker) _isValid = true;
        }

        if (!_isValid)
        {
            _isValid = _cardHolder.PCardScripts[0].Card.suit != _cardHolder.PCardScripts[^1].Card.suit;
            if (_cardHolder.PCardScripts[^1].Card.suit == Suits.Joker) _isValid = true;

            for (int i = 0; i < _cardHolder.PCardScripts.Count - 1; i++)
            {
                if (_cardHolder.PCardScripts[i].Card.suit == Suits.Joker)
                {
                    _isValid = true;
                    continue;
                }

                if (!_isValid) break;

                _isValid = _cardHolder.PCardScripts[i].Card.suit != _cardHolder.PCardScripts[i + 1].Card.suit;
                if (_cardHolder.PCardScripts[i + 1].Card.suit == Suits.Joker) _isValid = true;

                if (!_isValid) break;

                _isValid = _cardHolder.PCardScripts[i].Card.power == _cardHolder.PCardScripts[i + 1].Card.power;
                if (_cardHolder.PCardScripts[i + 1].Card.suit == Suits.Joker) _isValid = true;
            }
        }

    }
}
