using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Dynamic Product Price Analysis
        Console.WriteLine("TASK 1 - DYNAMIC PRODUCT PRICE ANALYSIS");
        DynamicProductPriceAnalysis task1 = new DynamicProductPriceAnalysis();
        double productAverage = task1.DynamicProductPriceAnalysisTask01();
        Console.WriteLine();

        // Task 2: Branch Sales Analysis
        Console.WriteLine("TASK 2 - BRANCH SALES ANALYSIS");
        BranchSalesAnalysis task2 = new BranchSalesAnalysis();
        int[,] sales = task2.BranchSalesAnalysisTask02();
        Console.WriteLine();

        // Task 3: Performance-Based Data Extraction
        Console.WriteLine("TASK 3 - PERFORMANCE-BASED DATA EXTRACTION");
        PerformanceBasedDataExtraction task3 = new PerformanceBasedDataExtraction();
        task3.PerformanceBasedDataExtractionTask03(sales, productAverage);
        Console.WriteLine();

        // Task 4: Customer Transaction Cleaning
        Console.WriteLine("TASK 4 - CUSTOMER TRANSACTION CLEANING");
        CustomerTransactionCleaning task4 = new CustomerTransactionCleaning();
        task4.CustomerTransactionCleaningTask04();
        Console.WriteLine();

        // Task 5: Financial Transaction Filtering
        Console.WriteLine("TASK 5 - FINANCIAL TRANSACTION FILTERING");
        FinancialTransactionFiltering task5 = new FinancialTransactionFiltering();
        task5.FinancialTransactionFilteringTask05(productAverage);
        Console.WriteLine();

        // Task 6: Process Flow Management
        Console.WriteLine("TASK 6 - PROCESS FLOW MANAGEMENT");
        ProcessFlowManagement task6 = new ProcessFlowManagement();
        task6.ProcessFlowManagementTask06();
        Console.WriteLine();

        // Task 7: Legacy Data Risk Demonstration
        Console.WriteLine("TASK 7 - LEGACY DATA RISK DEMONSTRATION");
        LegacyDataRiskDemonstration task7 = new LegacyDataRiskDemonstration();
        task7.LegacyDataRiskDemonstrationTask07();
    }
}