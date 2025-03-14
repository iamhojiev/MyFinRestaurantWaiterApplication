using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UC
{
    public partial class UC_HallTableCategories : UserControl
    {
        public UC_HallTableCategories()
        {
            InitializeComponent();
            ConfigureDataGrids();
            metroTabControl2.SelectedIndex = 0;
            UpdateAllAsync(); // Changed to async method
        }

        private void ConfigureDataGrids()
        {
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKitchen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private async void UpdateAllAsync() // Made this method async
        {
            await Task.WhenAll(UpdateGridTable(), UpdateGridHall(), UpdateGridKitchen(), UpdateGridCategory());
        }

        private async Task UpdateGridTable() // Changed return type to Task
        {
            var hallsTask = new Hall().OnLoadAllAsync();
            var tablesTask = new Tables().OnLoadAsync();
            var tableStatusesTask = new TableStatus().OnLoadAsync();

            await Task.WhenAll(hallsTask, tablesTask, tableStatusesTask); // Await all tasks

            var halls = await hallsTask;
            var tables = await tablesTask;
            var tableStatuses = await tableStatusesTask;

            var bindingSource = new BindingSource();

            if (halls != null && tables != null && tableStatuses != null)
            {
                foreach (var table in tables)
                {
                    table.hall = halls.FirstOrDefault(h => h.hall_id == table.table_hall_id);
                    table.tables_status = tableStatuses.FirstOrDefault(ts => ts.table_st_id == table.table_status);
                    bindingSource.Add(table);
                }
                dgvTables.DataSource = bindingSource;
            }
            else
            {
                Dialog.Error("Не удалось загрузить данные.");
                dgvTables.DataSource = null;
            }
        }

        private async Task UpdateGridHall() // Changed return type to Task
        {
            var halls = await new Hall().OnLoadHallsAsync();
            var bindingSource = new BindingSource();

            if (halls != null)
            {
                foreach (var hall in halls)
                {
                    bindingSource.Add(hall);
                }
                dgvHall.DataSource = bindingSource;
            }
            else
            {
                dgvHall.DataSource = null;
            }
        }

        private async Task UpdateGridKitchen() // Changed return type to Task
        {
            var kitchens = await new Kitchen().OnLoadAsync();
            var bindingSource = new BindingSource();

            if (kitchens != null)
            {
                foreach (var kitchen in kitchens)
                {
                    bindingSource.Add(kitchen);
                }
                dgvKitchen.DataSource = bindingSource;
            }
            else
            {
                dgvKitchen.DataSource = null;
            }
        }

        private async Task UpdateGridCategory() // Changed return type to Task
        {
            var categories = await new StockCategory().OnLoadAsync();
            var bindingSource = new BindingSource();

            if (categories != null)
            {
                foreach (var category in categories)
                {
                    bindingSource.Add(category);
                }
                dgvCategory.DataSource = bindingSource;
            }
            else
            {
                dgvCategory.DataSource = null;
            }
        }

        public async void UpdateCurrentTab()
        {
            // Получаем индекс текущей вкладки
            int selectedTabIndex = metroTabControl2.SelectedIndex;

            // В зависимости от выбранного таба обновляем соответствующий DataGrid
            switch (selectedTabIndex)
            {
                case 0: // Вкладка для таблиц
                    await UpdateGridTable();
                    break;

                case 1: // Вкладка для залов
                    await UpdateGridHall();
                    break;

                case 2: // Вкладка для кухни
                    await UpdateGridKitchen();
                    break;

                case 3: // Вкладка для категорий
                    await UpdateGridCategory();
                    break;

                default:
                    // В случае, если индекс не соответствует известным вкладкам, можно обработать ошибку
                    Dialog.Error("Неизвестный индекс вкладки.");
                    break;
            }
        }

    }
}