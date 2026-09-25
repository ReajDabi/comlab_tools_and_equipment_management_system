using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;

namespace ComLabManager.UI
{
    public partial class MainForm : Form
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private User _currentUser; 

       
        public MainForm(IEquipmentRepository equipmentRepository)
        {
            InitializeComponent();
            _equipmentRepository = equipmentRepository;
        }

        
        public void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

       
    }

}
    
