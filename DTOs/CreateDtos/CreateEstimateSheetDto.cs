﻿namespace pba_api.DTOs.CreateDtos
{
    public class CreateEstimateSheetDto
    {
        /// <summary>
        /// Name of the <see cref="EstimateSheetDto"/>
        /// </summary>
        public string SheetName { get; set; } = string.Empty;

        /// <summary>
        /// Id of the Jira Board, where the <see cref="EstimateSheetDto"/> sends and gets task
        /// </summary>
        public int JiraBoardId { get; set; }

        /// <summary>
        /// Link to Workbook
        /// </summary>
        public string WorkbookLink { get; set; } = string.Empty;

        /// <summary>
        /// Link to Jira Board
        /// </summary>
        public string JiraLink { get; set; } = string.Empty;

        /// <summary>
        /// Link to Wireframes
        /// </summary>
        public string WireframeLink { get; set; } = string.Empty;

        public int CustomerId { get; set; }

        public int SheetStatusId { get; set; }
    }
}
