using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
//using WBFSe;
//using WBFSe.Attributes;
//using WBFSe.Data;
//using WBFSe.FormatApi;
//using WBFSe.Formats;
//using WBFSe.IO;
//using WBFSe.IO.Drives;
//using WBFSe.IO.Files;
//using WBFSe.IO.Streams;
//using WBFSe.OS;

namespace WBFSManager
{
    public partial class MainWindow : Telerik.WinControls.UI.RadForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void radMenuItem9_Click(object sender, EventArgs e)
		{

		}

		private void radMenuItem6_Click(object sender, EventArgs e)
		{

		}

		private void radMenuItem8_Click(object sender, EventArgs e)
		{

		}

		private void radMenuItem18_Click(object sender, EventArgs e)
		{

		}

		private void ultraDataSource1_CellDataRequested(object sender, Infragistics.Win.UltraWinDataSource.CellDataRequestedEventArgs e)
		{

		}

		private void RadForm1_Load(object sender, EventArgs e)
		{

		}

		private void radMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void radGroupBox1_Click(object sender, EventArgs e)
		{

		}

		private void radMenuItem24_Click(object sender, EventArgs e)
		{

		}

		private void radMenuItem17_Click(object sender, EventArgs e)
		{

		}

		private void radMenuItem1_Click_1(object sender, EventArgs e)
		{

		}

		//private static void LoadFolderAsync(Object o)
		//{
		//    FolderOperation op = o as FolderOperation;
		//    WbfsFileInfo current;
		//    WbfsError error;

		//    for (int i = 0; i < op.Directory.Files.Length; i++)
		//    {
		//        while (op.IsPaused)
		//            Thread.Sleep(10);

		//        if (op.IsCanceled)
		//            return;

		//        error = WbfsError.Ok;
		//        current = null;

		//        if (op.Directory.Files[i] == null)
		//            goto ENDFILE;

		//        error = WbfsLoader.LoadFile(op.Directory,
		//            op.Directory[i], out current);

		//        if (error != WbfsError.Ok)
		//        {
		//            if ((error != WbfsError.FileNotAGame) && 
		//                (error != WbfsError.FormatNotSupported))
		//            {
		//                MessageBox.Show(String.Format("Failed to load file {0}, error {1}",
		//                    op.Directory.Files[i], error), "WbfsSync", MessageBoxButton.OK,
		//                    MessageBoxImage.Error);
		//            }
		//        }

		//    ENDFILE:
		//        op.CurrentFile = current;
		//        op.Step(1, WbfsError.Ok);
		//    }

		//    // Send the normal files
		//    op.TotalCount = 1;
		//    for (int i = 0; i < op.Directory.Files.Length; i++)
		//    {
		//        if (op.Directory.Files[i] != null)
		//        {
		//            op.Total = 0;
		//            op.CurrentFile = new FileInfo(op.Directory[i]);
		//            if (!op.CurrentFile.Attributes.HasFlag(FileAttributes.System))
		//            {
		//                op.Step(1, WbfsError.Ok);
		//            }
		//        }
		//    }
		//}

		private void radMenuItem_Folders_Add_Folders_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.AutoFlush = true;

			folderBrowserDialog1.ShowNewFolderButton = false;
			folderBrowserDialog1.Description = "Select which folders to search for discs...";

			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				IEnumerable<String> items = Directory.EnumerateFileSystemEntries(folderBrowserDialog1.SelectedPath);
				using (IEnumerator<String> en = items.GetEnumerator())
				{
					return !en.MoveNext();
				}

				//String[] folders = Directory.EnumerateFileSystemEntries(folderBrowserDialog1.SelectedPath, "*", SearchOption.TopDirectoryOnly);

			    for (int i = 0; i < folders.Length; ++i)
			    {
					FileAttributes attributes = File.GetAttributes(folders[i]);

					Boolean archive = attributes.HasFlag(FileAttributes.Archive);
					Boolean compressed = attributes.HasFlag(FileAttributes.Compressed);
					Boolean device = attributes.HasFlag(FileAttributes.Device);
					Boolean directory = attributes.HasFlag(FileAttributes.Directory);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.Encrypted);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.Hidden);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.Normal);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.NotContentIndexed);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.Offline);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.ReadOnly);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.ReparsePoint);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.SparseFile);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.System);
					Boolean reparse_point = attributes.HasFlag(FileAttributes.Temporary);



(File.GetAttributes(subdir) &
            FileAttributes.ReparsePoint) !=
                FileAttributes.ReparsePoint)

			}



			//    //IWbfsDriveInfo drive = WBFSe.WbfsEngine.GetDrive(folderBrowserDialog1.SelectedPath);
			//    ////String[] files = drive.GetFilenames(folderBrowserDialog1.SelectedPath);
			//    //System.Diagnostics.Debug.WriteLine("{0} - {1} - {2} - {3} - {4}", folderBrowserDialog1.SelectedPath, drive.FileSystem, drive.Free, drive.IsWbfsFat, drive.IsReady);

			//    String[] folders = Directory.GetDirectories(folderBrowserDialog1.SelectedPath, "*", SearchOption.AllDirectories);

			//    //System.Diagnostics.Debug.WriteLine("{0} - {1}", folders.Length, files.Length);
			//    //IWbfsFormat[] formats = WbfsEngine.GetLoadedFormats();

			//    WBFSe3.IO.WbfsLoader.LoadBuiltIn();


			//    for (int i = 0; i < folders.Length; ++i)
			//    {
			//        WBFSe3.IO.WbfsPath path = new WBFSe3.IO.WbfsPath(folders[i]);

			//        String[] files = Directory.GetFiles(folders[i], "*", SearchOption.AllDirectories);

			//    for (int j = 0; j < files.Length; ++i)
			//    {

			//        WBFSe3.IO.WbfsLoader.LoadFile(path, folders[i] );




			//    WBFSe3.IO.WbfsSearch.InsertDirectory(folderBrowserDialog1.SelectedPath);

			//    WBFSe3.IO.WbfsFileInfo[] file_infos = WBFSe3.IO.WbfsSearch.GetFiles(folderBrowserDialog1.SelectedPath, true);

			//    System.Diagnostics.Debug.WriteLine("{0} - {1}", file_infos.Length, file_infos.LongLength);

			//    for (int i = 0; i < file_infos.Length; ++i)
			//    {
			//        WBFSe3.IO.WbfsFileInfo file_info = file_infos[i];
			//        if(file_info != null)
			//        //{
			//        //    System.Diagnostics.Debug.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", Path.GetFullPath(file_infos[i].FullName), Path.GetPathRoot(file_infos[i].FullName), Path.GetDirectoryName(file_infos[i].FullName), Path.GetFileName(file_infos[i].FullName), Path.GetFileNameWithoutExtension(file_infos[i].FullName), Path.GetExtension(file_infos[i].FullName));
			//        //}
			//        //else
			//        {
			//            System.Diagnostics.Debug.WriteLine("{0} - {1} - {2} - {3} - {4}", file_info.Code, file_info.Name, file_info.State, file_info.Name, file_info.Region);
			//        }

			//    }

			//    //for (int i = 0; i < files.Length; ++i)
			//    //{
			//    //    IWbfsFileInfo file_info;
			//    //    Boolean error = WbfsEngine.LoadGame(Path.GetFullPath(files[i]), files, files[i], null, out file_info);

			//    //    System.Diagnostics.Debug.WriteLine("{0} - {1} - {2}", files[i], error, file_info);

			//    //    if(error || file_info == null)
			//    //    {
			//    //        System.Diagnostics.Debug.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", Path.GetFullPath(files[i]), Path.GetPathRoot(files[i]), Path.GetDirectoryName(files[i]), Path.GetFileName(files[i]), Path.GetFileNameWithoutExtension(files[i]), Path.GetExtension(files[i]));
			//    //    }
			//    //    else
			//    //    {
			//    //        System.Diagnostics.Debug.WriteLine("{0} - {1} - {2} - {3} - {4}", file_info.Code, file_info.Name, file_info.Type, file_info.Path, file_info.Format.Description);
			//    //    }

				//}
			}

		private void radMenuItem6_Click_1(object sender, EventArgs e)
		{
		
		}

		private void radMenuItem_Settings_Click(object sender, EventArgs e)
		{
		
		}

		private void radMenuItem10_Click(object sender, EventArgs e)
		{
		
		}

		private void radScrollablePanel1_Click(object sender, EventArgs e)
		{
		
		}





				//bool LoadGame(string directory, string[] filenames,  string filename, IWbfsFormat format, out IWbfsFileInfo file)


				//foreach(String file in files)
				//{
				//    IWbfsFileInfo file_info;
				//    Boolean error = WbfsLoader.LoadFile(op.Directory, op.Directory[i], out file_info);
				//   // System.Diagnostics.Trace.WriteLine(file_info.Code + " - " + file_info.Name + " - " + file_info.Type.ToString());
				//}

			//    WBFSe3.IO.WbfsSearch.InsertDirectory(folderBrowserDialog1.SelectedPath);

			//    IWbfsFileInfo[] file_infos = (IWbfsFileInfo[])WBFSe3.IO.WbfsSearch.GetFiles(folderBrowserDialog1.SelectedPath, true);

			//    foreach(IWbfsFileInfo file_info in file_infos)
			//    {
			//        System.Diagnostics.Trace.WriteLine(file_info.Code + " - " + file_info.Name + " - " + file_info.Type.ToString());
			//    }}

								//String[] files = di.GetFilenames(folderBrowserDialog1.SelectedPath);
				//IWbfsFormat[] format = WbfsLoader.GetLoadedFormats();
				//WbfsLoader.
				//IWbfsFormat fmt;
				//IWbfsFileInfo fili;
				//Boolean result = WBFSe.WbfsEngine.LoadGame(folderBrowserDialog1.SelectedPath, files[0], null, out fili);
				//WBFSe.WbfsEngine.FindFiles("", SearchMode.All);
				//Boolean result = WBFSe.WbfsEngine.LoadGame(folderBrowserDialog1.SelectedPath, files[0], null, out fili);
				//String[] files = di.GetFilenames(folderBrowserDialog1.SelectedPath);

                

				//if (error != WbfsError.Ok)
				//{
				//    if ((error != WbfsError.FileNotAGame) && 
				//        (error != WbfsError.FormatNotSupported))
				//    {
				//        MessageBox.Show(String.Format("Failed to load file {0}, error {1}",
				//            op.Directory.Files[i], error), "WbfsSync", MessageBoxButton.OK,
				//            MessageBoxImage.Error);
				//    }
				//}





			//    //IWbfsError error;
			//    IWbfsDriveInfo drive;
			//    //IWbfsPath directory;
			//    IWbfsFileInfo[] indexed;
			//    Int32 toLoad = 0;


			//if (!drive.IsWbfs)
			//{
			//    try
			//    {
			//        directory = new WbfsPath(path);
			//        DirectoryInfo di = new DirectoryInfo(path);
			//        DirectoryInfo[] folders = di.GetDirectories();

			//        // Add the folders
			//        foreach (DirectoryInfo d in folders)
			//        {
			//            if (d.Attributes.HasFlag(FileAttributes.System))
			//                continue;

			//            CurrentLoadOperation.CurrentFile = d;

			//            if (asyncResponse != null)
			//                asyncResponse(CurrentLoadOperation,
			//                    WbfsError.Ok, 0);
			//        }
			//    }
			//    catch (Exception exception)
			//    {
			//        MessageBox.Show(exception.Message, "WbfsSync",
			//            MessageBoxButton.OK, MessageBoxImage.Error);

			//        return;
			//    }
			//}
			//else
			//{
			//    WbfsDevice device = drive as WbfsDevice;
			//    directory = new WbfsPath(device.Name,
			//        device.GetFileNames());
			//}

			//// Filter the indexed files
			//indexed = WbfsSearch.GetIndexed(directory);
			//foreach (WbfsFileInfo fi in indexed)
			//{
			//    if (fi.IsTemporary) continue;
			//    CurrentLoadOperation.CurrentFile = fi;

			//    if (asyncResponse != null)
			//        asyncResponse(CurrentLoadOperation,
			//            WbfsError.Ok, 0);
			//}

			//// Count the not loaded files
			//if (drive.IsWbfs)
			//{
			//    foreach (String f in directory.Files)
			//        if (f != null) toLoad++;
			//}
			//else
			//{
			//    toLoad = WbfsLoader.CountKnownFormats(directory.Files);
			//}

		}

		private void radMenuItem_Folders_Add_Files_Click(object sender, EventArgs e)
		{

		}
    }
}
