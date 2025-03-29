using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MyFinCassa.UC;
using MyFinCassa.Model;
using MyFinCassa.Database;
using MyFinCassa.Properties;
using MyFinCassa.Helper;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmCardType : Form
    {
        public Card SelectedCard { get; private set; }
        private string currency;

        public FrmCardType()
        {
            InitializeComponent();

            UpdateCard();
        }

        private async void UpdateCard()
        {
            try
            {
                currency = await new Currency().OnGetCurrencyValueAsync();
                var cards = await new Card().OnLoadAsync();
                CreateTableLayoutGroup(cards, mainContainer, cards.Count);
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка обновления карт: {ex.Message}");
            }
        }

        private void CreateTableLayoutGroup(List<Card> cards, Control parent, int count)
        {
            if (count <= 0) return;

            var tlg = new TableLayoutPanel
            {
                RowCount = (count - 1) / 3 + 1,
                ColumnCount = Math.Min(count, 3),
                Dock = DockStyle.Fill
            };

            for (int i = 0; i < tlg.RowCount; i++)
            {
                tlg.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / tlg.RowCount));
            }

            for (int i = 0; i < tlg.ColumnCount; i++)
            {
                tlg.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / tlg.ColumnCount));
            }

            parent.Controls.Add(tlg);

            for (int j = 0; j < cards.Count; j++)
            {
                var card = cards[j];
                var cardBtn = new CardBtn
                {
                    Dock = DockStyle.Fill,
                    CardGunaButton = { Tag = card, Text = $"{card.card_name}\nБаланс: {card.card_balance} {currency}" },
                    CardLogo = { Tag = card },
                };

                var imageName = $"{card.card_name}{card.card_id}.png";
                var image = ImageServerIO.GetImage(imageName);
                cardBtn.CardLogo.Image = image ?? Resources.cameraOf_high;

                cardBtn.CardGunaButton.Click += CardBtnClick;
                cardBtn.CardLogo.Click += CardBtnClick;

                int row = j / 3;
                int column = j % 3;
                tlg.Controls.Add(cardBtn, column, row);
            }
        }

        private void CardBtnClick(object sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is Card card)
            {
                SelectedCard = card;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                btnClose.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
