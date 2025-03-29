using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UC
{
    public partial class UC_CasheHistory : UserControl
    {
        public UC_CasheHistory()
        {
            InitializeComponent();
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        public async Task UpdateGridAsync()
        {
            var cassaTransactions = await new CassaLog().OnLoadTransactionsAsync();
            var users = await new User().OnAllUserAsync();
            var cassas = await new Cassa().OnLoadAsync();
            var cards = await new Card().OnLoadAsync();

            foreach (var transaction in cassaTransactions)
            {
                transaction.user = users.FirstOrDefault(u => u.user_id == transaction.transaction_user);
                if (transaction.transaction_cassa != 0)
                {
                    transaction.cassa = cassas?.FirstOrDefault(c => c.cassa_id == transaction.transaction_cassa);
                }
                else if (transaction.transaction_card != 0)
                {
                    transaction.card = cards?.FirstOrDefault(c => c.card_id == transaction.transaction_card);
                }
            }
            dgvMain.DataSource = cassaTransactions;
        }
    }
}
