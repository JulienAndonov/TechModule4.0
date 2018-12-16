using System;
using System.Text;

namespace SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(":");
                string artist = tokens[0];
                string song = tokens[1];
                bool isValidArtist = false;
                bool isValidSong = false;

                if (char.IsUpper(artist[0]))
                {
                    for (int i = 1; i < artist.Length; i++)
                    {
                        if (char.IsLower(artist[i]) || artist[i] == '\'' || artist[i] == ' ')
                        {
                            isValidArtist = true;
                        }
                        else
                        {
                            isValidArtist = false;
                            break;
                        }
                    }
                }


                for (int i = 0; i < song.Length; i++)
                {
                    if (char.IsUpper(song[i]) || song[i] == ' ')
                    {
                        isValidSong = true;
                    }
                    else
                    {
                        isValidSong = false;
                        break;
                    }
                }

                if (isValidArtist && isValidSong)
                {
                    int encryptionKeyArtist = artist.Length;
                    int encryptionKeySong = artist.Length;
                    StringBuilder encryptedArtist = new StringBuilder();
                    StringBuilder encryptedSong = new StringBuilder();

                    for (int i = 0; i < artist.Length; i++)
                    {

                        if (artist[i] == ' ' || artist[i] == '\'')
                        {
                            encryptedArtist.Append(artist[i]);
                        }
                        else
                        {
                            char ch;

                            ch = (char)((int)artist[i] + encryptionKeyArtist);
                            if (char.IsLower(artist[i]) && ch > 'z')
                            {
                                int difference = (int)ch - 122;
                                ch = (char)(97 + difference - 1);
                            }
                            else if (char.IsUpper(artist[i]) && ch > 'Z')
                            {
                                int difference = (int)ch - 90;
                                ch = (char)(65 + difference - 1);
                            }

                            encryptedArtist.Append(ch);
                        }
                    }


                    for (int i = 0; i < song.Length; i++)
                    {
                        if (song[i] == ' ' || song[i] == '\'')
                        {
                            encryptedSong.Append(song[i]);
                        }
                        else
                        {
                            char ch;
                            ch = (char)((int)song[i] + encryptionKeySong);
                            if (ch > 'Z')
                            {
                                int difference = (int)ch - 90;
                                ch = (char)(65 + difference - 1);
                            }
                            encryptedSong.Append(ch);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {encryptedArtist}@{encryptedSong}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
