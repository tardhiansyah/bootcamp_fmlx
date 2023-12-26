using System;
using System.IO;

public class ResourceHandler : IDisposable
{
    private MemoryStream managedResource;
    private FileStream unmanagedResource;
    private bool disposedValue;

    public ResourceHandler(string filePath)
    {
        managedResource = new MemoryStream();
        unmanagedResource = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    }

    public void WriteToMemory(string content)
    {
        if (disposedValue)
        {
            throw new ObjectDisposedException("Resources Handler");
        }

        byte[] data = System.Text.Encoding.UTF8.GetBytes(content);
        managedResource.Write(data, 0, data.Length);

    }


    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                managedResource.Dispose();
                managedResource = null;
            }

            if (unmanagedResource != null)
            {
                unmanagedResource.Close();
                unmanagedResource = null;
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    ~ResourceHandler()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}