﻿using ERP.DAL.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VTPL_ERP.Models
{
    public class SalesEntryViewModel
    {
        public string SalesEntryNo { get; set; }
        public DateTime SalesEntryDate { get; set; }
        public string SalesDateString { get; set; }
        public string SEDateDisplay { get; set; }
        public List<AccountPartyMasterDto> SupplierList { get; set; }
        public List<InventoryMasterDto> StockItemList { get; set; }
        public List<OtherChargesMasterDto> OtherChargesList { get; set; }
        public List<SalesEntryDetailsViewModel> SalesEntryDetails { get; set; }
        public List<SEOtherChargesDetailsViewModel> SEOtherChargesDetails { get; set; }

        public List<SalesEntryDetailsDto> SalesEntryDetailsData { get; set; }
        public List<SEOtherChargesDetailsDto> SEOtherChargesDetailsData { get; set; }

        public SelectList SupplierSelectList { get; set; }
        public SelectList StockItemSelectList { get; set; }
        public SelectList OtherChargesSelectList { get; set; }
        public SelectList BranchSelectList { get; set; }

        public int SelectedSupplierId { get; set; }
        public int SelectedStockItemId { get; set; }
        public int SelectedOtherChargesId { get; set; }
        public int SelectedBranchId { get; set; }

        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string RefNo { get; set; }
        public int SupplierId { get; set; }
        public decimal CurrentBalance { get; set; }
        public string SalesAccount { get; set; }
        public string DispatchedBy { get; set; }
        public string DispatchedDocateNo { get; set; }
        public string Destination { get; set; }
        public string Narration { get; set; }
        public int TotalQty { get; set; }
        public decimal Amount { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal DiscAmount { get; set; }
        public decimal SGST { get; set; }
        public decimal CGST { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public decimal RoundOff { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Modified_Date { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public string PageMode { get; set; }
        public int PaymentStatus { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierGSTNumber { get; set; }
        public string SupplierPANNumber { get; set; }
        public string SupplierStateTINNo { get; set; }
        public string SupplierStateName { get; set; }
        public int SupplierCreditPeriod { get; set; }
        public string JsonOtherChargesData { get; set; }
        public List<string> StockSerialIds { get; set; }
    }
}