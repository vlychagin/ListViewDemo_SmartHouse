using SmartHouse.Models;

namespace SmartHouse;

public partial class MainForm : Form
{
    Apartment Apartment { get; set; }

    public MainForm() {
        InitializeComponent();

        // ������� ��������
        Apartment = ApartmentFactory.Create(Random.Shared.Next(12, 16));
        StlMain.Text = $"{Apartment.Address}. ����� ��������: {Apartment.Appliances.Count}";

        // ������� ������� �������� � �������� ListView
        ToListView(LsvAppliances, Apartment.Appliances);
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.Name));
        ToListView(LsvSelected, Apartment.WhereMinPrice());

        TbpOrdered.Text = "�������������� �� ��������";
        TbpSelected.Text = "�������������� � ����������� �����";

        TbcMain.SelectedTab = TbpData;
    } // MainForm


    private void ApplicationExit_Action(object sender, EventArgs e) =>
        Application.Exit();


    // ������� ��������� �������� � �������� ListView
    private void ToListView(ListView LsvDest, List<Appliance> data) {
        // ������ �������� ListView
        LsvDest.Items.Clear();

        // ���������� ListView
        data.ForEach(appliance => {
            ListViewItem listViewItem = new ListViewItem("", appliance.ImageIndex);

            listViewItem.SubItems.Add($"{appliance.Id}");
            listViewItem.SubItems.Add(appliance.Name);
            listViewItem.SubItems.Add($"{appliance.Power}");
            listViewItem.SubItems.Add(appliance.State ? "�������" : "��������");
            listViewItem.SubItems.Add($"{appliance.Price:n2}");

            LsvDest.Items.Add(listViewItem);
        });
    } // ToListView


    private void NewApartment_Action(object sender, EventArgs e) {
        Apartment = ApartmentFactory.Create(Random.Shared.Next(12, 16));

        StlMain.Text = $"{Apartment.Address}. ����� ��������: {Apartment.Appliances.Count}";

        // ������� ������� �������� � �������� ListView
        ToListView(LsvAppliances, Apartment.Appliances);
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.Power));
        ToListView(LsvSelected, Apartment.WhereMinPrice());

        TbpOrdered.Text = "�������������� �� ��������";
        TbpSelected.Text = "�������������� � ����������� �����";

        TbcMain.SelectedTab = TbpData;
    } // NewApartment_Action

    #region ���������� ����� ���������
    // ������� ������������� �� �������� ����� ��������� ���������������, 
    // ������� �� ������� ������������� ���������������
    private void OrderByName_Action(object sender, EventArgs e) {
        TbpOrdered.Text = "�������������� �� ��������";
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.Name));
        TbcMain.SelectedTab = TbpOrdered;
    } // OrderByName_Action


    // ������� ������������� �� �������� �������� ����� ��������� ���������������, 
    // ������� �� ������� ������������� ���������������
    private void OrderByPowerDesc_Action(object sender, EventArgs e) {
        TbpOrdered.Text = "�������������� �� �������� ��������";
        ToListView(LsvOrdered, Apartment.OrderByDescending(a => a.Power));
        TbcMain.SelectedTab = TbpOrdered;
    } // OrderByPowerDesc_Action


    // ������� ������������� �� ���� ����� ��������� ���������������, 
    // ������� �� ������� ������������� ���������������
    private void OrderByPrice_Action(object sender, EventArgs e) {
        TbpOrdered.Text = "�������������� �� ����";
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.Price));
        TbcMain.SelectedTab = TbpOrdered;
    } // OrderByPrice_Action


    // ������� ������������� �� ��������� ����� ��������� ���������������, 
    // ������� �� ������� ������������� ���������������
    private void OrderByState_Action(object sender, EventArgs e) {
        TbpOrdered.Text = "�������������� �� ���������";
        ToListView(LsvOrdered, Apartment.OrderBy(a => a.State));
        TbcMain.SelectedTab = TbpOrdered;
    } // OrderByState_Action
    #endregion


} // class MainForm
