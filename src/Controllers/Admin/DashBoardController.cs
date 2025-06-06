﻿using BTL_C_.src.DAO;
using BTL_C_.src.Views.Admin;

namespace BTL_C_.src.Controllers.Admin
{
  internal class DashBoardController
  {
    private DashBoardControl viewDashBoardControl;
    private ProductDAO productDao;
    private SupplierDAO supplierDao;
    private CustomerDAO customerDao;
    private EmployeeDAO employeeDao;
    private CategoryDAO categoryDao;
    private MaterialDAO materialDao;
    private TaskDAO taskDao;
    private SalesInvoiceDAO salesInvoiceDao;
    private PurchaseInvoiceDAO purchaseInvoiceDao;
    public DashBoardController(DashBoardControl viewDashBoardControl)
    {
      this.viewDashBoardControl = viewDashBoardControl;
      productDao = new ProductDAO();
      supplierDao = new SupplierDAO();
      customerDao = new CustomerDAO();
      employeeDao = new EmployeeDAO();
      categoryDao = new CategoryDAO();
      materialDao = new MaterialDAO();
      taskDao = new TaskDAO();
      salesInvoiceDao = new SalesInvoiceDAO();
      purchaseInvoiceDao = new PurchaseInvoiceDAO();
      loadFormData();
    }
    private void loadFormData()
    {
      int slsp = productDao.getCount();
      int slncc = supplierDao.getCount();
      int slkh = customerDao.getCount();
      int slnv = employeeDao.getCount();
      int slcl = materialDao.getCount();
      int sll = materialDao.getCount();
      int slcv = taskDao.getCount();
      int slhdn = purchaseInvoiceDao.getCount();
      int slhdb = salesInvoiceDao.getCount();
      viewDashBoardControl.loadFormData(slsp, slncc, slkh, slnv, slcl, sll, slcv, slhdn, slhdb);
    }
  }
}
