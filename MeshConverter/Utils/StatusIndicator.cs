using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshManager.Utils
{
	public class StatusIndicator
	{
		private int currentProgress = 0;
		private int maxProgress = 1;

		public string Text { get; set; }

		public bool InProgress { get; set; }

		public bool CancelRequested { get; set; }

		public int CurrentProgress
		{
			get { return currentProgress; }
			set
			{
				if (value > maxProgress) { maxProgress = value; }
				currentProgress = value;
			}
		}

		public int MaxProgress
		{
			get { return maxProgress; }
			set
			{
				maxProgress = value;
				if (currentProgress > maxProgress) { currentProgress = maxProgress; }
			}
		}


		public void ResetAndStart()
		{
			this.currentProgress = 0;
			this.maxProgress = 0;
			this.Text = "";
			this.InProgress = true;
		}

		public void SetCompleted()
		{
			this.InProgress = false;
			this.currentProgress = this.maxProgress;
		}

		public void Cancel()
		{
			CancelRequested = true;
		}
	}
}
