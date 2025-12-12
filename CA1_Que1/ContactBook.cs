// Contact Book Class
using System;
using System.Collections.Generic;

public class ContactBook
{
    private List<Contact> _contacts = new List<Contact>();


    // Adding Contact
    public void AddContact(Contact newContact)
    {
        _contacts.Add(newContact);
        Console.WriteLine("Contact added successfully.");
    }


    // Displaying all contacts
    public void ShowAllContacts()
    {
        if (_contacts.Count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        foreach (Contact contact in _contacts)
            contact.Show();
    }


    // Showing Contact Details
    public void ShowContactDetails(string mobile)
    {
        bool isFound = false;
        Contact foundContact = null;

        foreach (Contact item in _contacts)
        {
            if (item.MobileNumber == mobile)
            {
                foundContact = item;
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Contact not found.");
            return;
        }

        foundContact.Show();
    }


    // To Update Contact
    public void UpdateContact(string mobile)
    {
        bool isFound = false;
        Contact foundContact = null;

        foreach (Contact item in _contacts)
        {
            if (item.MobileNumber == mobile)
            {
                foundContact = item;
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Contact not found.");
            return;
        }

        try
        {
            Console.Write("New First Name: ");
            foundContact.FirstName = Console.ReadLine();

            Console.Write("New Last Name: ");
            foundContact.LastName = Console.ReadLine();

            Console.Write("New Company: ");
            foundContact.Company = Console.ReadLine();

            Console.Write("New Mobile Number: ");
            foundContact.MobileNumber = Console.ReadLine();

            Console.Write("New Email: ");
            foundContact.Email = Console.ReadLine();

            Console.Write("New Birthdate (yyyy-mm-dd): ");
            foundContact.Birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Contact updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error updating contact: " + ex.Message);
        }
    }


    //
    public void DeleteContact(string mobile)
    {
        bool isFound = false;
        Contact foundContact = null;

        foreach (Contact item in _contacts)
        {
            if (item.MobileNumber == mobile)
            {
                foundContact = item;
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Contact not found.");
            return;
        }

        _contacts.Remove(foundContact);
        Console.WriteLine("Contact deleted.");
    }


   
    public int ContactCount()
    {
        return _contacts.Count;
    }
}
