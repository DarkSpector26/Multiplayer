/*READ ME
 * This script manages player listings by assigning player information
 * to a text component, displaying the player's nickname in the UI
 * using the `SetPlayerInfo` method.
 */
using UnityEngine;
using TMPro;
using Photon.Realtime;

public class PlayerListing : MonoBehaviour
{
    private TMP_Text _playerListingText;

    public Player playerInfo { get; set; }

    private void Awake()
    {
        _playerListingText = GetComponentInChildren<TMP_Text>();
    }

    // Set player information and update the text
    public void SetPlayerInfo(Player _player)
    {
        playerInfo = _player;
        _playerListingText.text = playerInfo.NickName; // Display the player's nickname
    }
    public void SetScore(Player player)
    {
        var result = player.CustomProperties["score"];
        _playerListingText.text = result.ToString() + " | " + player.NickName;
    }
}
