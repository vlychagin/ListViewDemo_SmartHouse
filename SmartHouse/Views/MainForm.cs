using SmartHouse.Models;

namespace SmartHouse;

public partial class MainForm : Form
{
    Apartment Apartment { get; set; }

    public MainForm() {
        InitializeComponent();

        // создать квартиру
        Apartment = ApartmentFactory.Create(Random.Shared.Next(12, 16));
        StlMain.Text = $"{Apartment.Address}. Всего приборов: {Apartment.Appliances.Count}";

        // Вывести приборы квартиры в заданный ListView
        ToListView(LsvAppliances, Apartment.Appliances);
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.Name));
        ToListView(LsvSelected, Apartment.WhereMinPrice());

        TbpOrdered.Text = "Электроприборы по названию";
        TbpSelected.Text = "Электроприборы с минимальной ценой";

        TbcMain.SelectedTab = TbpData;
    } // MainForm


    private void ApplicationExit_Action(object sender, EventArgs e) =>
        Application.Exit();


    // Вывести коллекцию приборов в заданный ListView
    private void ToListView(ListView LsvDest, List<Appliance> data) {
        // чистим элементы ListView
        LsvDest.Items.Clear();

        // Заполнение ListView
        data.ForEach(appliance => {
            ListViewItem listViewItem = new ListViewItem("", appliance.ImageIndex);

            listViewItem.SubItems.Add($"{appliance.Id}");
            listViewItem.SubItems.Add(appliance.Name);
            listViewItem.SubItems.Add($"{appliance.Power}");
            listViewItem.SubItems.Add(appliance.State ? "включен" : "выключен");
            listViewItem.SubItems.Add($"{appliance.Price:n2}");

            LsvDest.Items.Add(listViewItem);
        });
    } // ToListView


    private void NewApartment_Action(object sender, EventArgs e) {
        Apartment = ApartmentFactory.Create(Random.Shared.Next(12, 16));

        StlMain.Text = $"{Apartment.Address}. Всего приборов: {Apartment.Appliances.Count}";

        // Вывести приборы квартиры в заданный ListView
        ToListView(LsvAppliances, Apartment.Appliances);
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.Power));
        ToListView(LsvSelected, Apartment.WhereMinPrice());

        TbpOrdered.Text = "Электроприборы по названию";
        TbpSelected.Text = "Электроприборы с минимальной ценой";

        TbcMain.SelectedTab = TbpData;
    } // NewApartment_Action

    #region сортировки копии коллекции
    // Вывести упорядоченную по названию копию коллекции электроприборов, 
    // перейти на вкладку упорядоченных электроприборов
    private void OrderByName_Action(object sender, EventArgs e) {
        TbpOrdered.Text = "Электроприборы по названию";
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.Name));
        TbcMain.SelectedTab = TbpOrdered;
    } // OrderByName_Action


    // Вывести упорядоченную по убыванию мощности копию коллекции электроприборов, 
    // перейти на вкладку упорядоченных электроприборов
    private void OrderByPowerDesc_Action(object sender, EventArgs e) {
        TbpOrdered.Text = "Электроприборы по убыванию мощности";
        ToListView(LsvOrdered, Apartment.OrderByDescending(a => a.Power));
        TbcMain.SelectedTab = TbpOrdered;
    } // OrderByPowerDesc_Action


    // Вывести упорядоченную по цене копию коллекции электроприборов, 
    // перейти на вкладку упорядоченных электроприборов
    private void OrderByPrice_Action(object sender, EventArgs e) {
        TbpOrdered.Text = "Электроприборы по цене";
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.Price));
        TbcMain.SelectedTab = TbpOrdered;
    } // OrderByPrice_Action


    // Вывести упорядоченную по состоянию копию коллекции электроприборов, 
    // перейти на вкладку упорядоченных электроприборов
    private void OrderByState_Action(object sender, EventArgs e) {
        TbpOrdered.Text = "Электроприборы по состоянию";
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.State));
        TbcMain.SelectedTab = TbpOrdered;
    } // OrderByState_Action
    #endregion


} // class MainForm
