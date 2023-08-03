// script.js
document.addEventListener("DOMContentLoaded", function () {
  var characters = [
    { name: "Arsène", checked: false },
    { name: "Jack-o'-Lantern", checked: false },
{ name: "Pixie", checked: false },
{ name: "Agathion", checked: false },
{ name: "Mandrake", checked: false },
{ name: "Bicorn", checked: false },
{ name: "Cait Sith", checked: false },
{ name: "Incubus", checked: false },
{ name: "Kelpie", checked: false },
{ name: "Saki Mitama", checked: false },
{ name: "Silky", checked: false },
{ name: "Genbu", checked: false },
{ name: "Succubus", checked: false },
{ name: "Obariyon", checked: false },
{ name: "Angel", checked: false },
{ name: "Berith", checked: false },
{ name: "Hua Po", checked: false },
{ name: "Koropokkuru", checked: false },
{ name: "Mokoi", checked: false },
{ name: "Regent", checked: false },
{ name: "Slime", checked: false },
{ name: "Apsaras", checked: false },
{ name: "Jack Frost", checked: false },
{ name: "Kodama", checked: false },
{ name: "Koppa Tengu", checked: false },
{ name: "Orpheus F DLC", checked: false },
{ name: "Kushi Mitama", checked: false },
{ name: "Onmoraki", checked: false },
{ name: "Ame-no-Uzume", checked: false },
{ name: "Ippon-Datara", checked: false },
{ name: "Orpheus F Picaro DLC", checked: false },
{ name: "Archangel", checked: false },
{ name: "Inugami", checked: false },
{ name: "Makami", checked: false },
{ name: "Queen's Necklace", checked: false },
{ name: "Shiisaa", checked: false },
{ name: "Eligor", checked: false },
{ name: "High Pixie", checked: false },
{ name: "Suzaku", checked: false },
{ name: "Kaguya DLC", checked: false },
{ name: "Matador", checked: false },
{ name: "Nekomata", checked: false },
{ name: "Orobas", checked: false },
{ name: "Sudama", checked: false },
{ name: "Black Ooze", checked: false },
{ name: "Shiki-Ouji", checked: false },
{ name: "Flauros", checked: false },
{ name: "Leanan Sidhe", checked: false },
{ name: "Nue", checked: false },
{ name: "Oni", checked: false },
{ name: "Stone of Scone", checked: false },
{ name: "Yaksini", checked: false },
{ name: "Izanagi DLC", checked: false },
{ name: "Orthrus", checked: false },
{ name: "Phoenix", checked: false },
{ name: "Jikokuten", checked: false },
{ name: "Nigi Mitama", checked: false },
{ name: "Fuu-Ki", checked: false },
{ name: "Sandman", checked: false },
{ name: "Izanagi Picaro DLC", checked: false },
{ name: "Naga", checked: false },
{ name: "Rakshasa", checked: false },
{ name: "Sui-Ki", checked: false },
{ name: "Anzu", checked: false },
{ name: "Kin-Ki", checked: false },
{ name: "Koh-i-Noor", checked: false },
{ name: "Setanta", checked: false },
{ name: "Kaguya Picaro DLC", checked: false },
{ name: "Isis", checked: false },
{ name: "Lamia", checked: false },
{ name: "Take-Minakata", checked: false },
{ name: "Orpheus DLC", checked: false },
{ name: "Andras", checked: false },
{ name: "Clotho", checked: false },
{ name: "Tam Lin", checked: false },
{ name: "Choronzon", checked: false },
{ name: "Pisaca", checked: false },
{ name: "Principality", checked: false },
{ name: "Orpheus Picaro DLC", checked: false },
{ name: "Ara Mitama", checked: false },
{ name: "Neko Shogun", checked: false },
{ name: "Orlov", checked: false },
{ name: "Ariadne DLC", checked: false },
{ name: "Kurama Tengu", checked: false },
{ name: "Zouchouten", checked: false },
{ name: "Decarabia", checked: false },
{ name: "Lilim", checked: false },
{ name: "Mitra", checked: false },
{ name: "Mothman", checked: false },
{ name: "Anubis", checked: false },
{ name: "Thunderbird", checked: false },
{ name: "Arahabaki", checked: false },
{ name: "Emperor's Amulet", checked: false },
{ name: "Lachesis", checked: false },
{ name: "Kaiwan", checked: false },
{ name: "Thoth", checked: false },
{ name: "Belphegor", checked: false },
{ name: "Hell Biker", checked: false },
{ name: "Legion", checked: false },
{ name: "White Rider", checked: false },
{ name: "Atropos", checked: false },
{ name: "Mithras", checked: false },
{ name: "Unicorn", checked: false },
{ name: "Daisoujou", checked: false },
{ name: "Hariti", checked: false },
{ name: "Hope Diamond", checked: false },
{ name: "Kikuri-Hime", checked: false },
{ name: "Power", checked: false },
{ name: "Red Rider", checked: false },
{ name: "Hecatoncheires", checked: false },
{ name: "Kumbhanda", checked: false },
{ name: "Kushinada", checked: false },
{ name: "Ose", checked: false },
{ name: "Ariadne Picaro DLC", checked: false },
{ name: "Girimehkala", checked: false },
{ name: "Queen Mab", checked: false },
{ name: "Yurlungur", checked: false },
{ name: "Ananta", checked: false },
{ name: "Valkyrie", checked: false },
{ name: "Magatsu-Izanagi DLC", checked: false },
{ name: "Byakko", checked: false },
{ name: "Pazuzu", checked: false },
{ name: "Fortuna", checked: false },
{ name: "Athena DLC", checked: false },
{ name: "Horus", checked: false },
{ name: "Narcissus", checked: false },
{ name: "Rangda", checked: false },
{ name: "Magatsu-Izanagi Picaro DLC", checked: false },
{ name: "Bugs", checked: false },
{ name: "Koumokuten", checked: false },
{ name: "Crystal Skull", checked: false },
{ name: "Dakini", checked: false },
{ name: "Sarasvati", checked: false },
{ name: "Athena Picaro DLC", checked: false },
{ name: "Tsukiyomi DLC", checked: false },
{ name: "Jatayu", checked: false },
{ name: "Seth", checked: false },
{ name: "Barong", checked: false },
{ name: "Garuda", checked: false },
{ name: "Mishaguji", checked: false },
{ name: "Norn", checked: false },
{ name: "Ganesha", checked: false },
{ name: "Skadi", checked: false },
{ name: "Okuninushi", checked: false },
{ name: "Pale Rider", checked: false },
{ name: "Cerberus", checked: false },
{ name: "Raja Naga", checked: false },
{ name: "Tsukiyomi Picaro DLC", checked: false },
{ name: "Parvati", checked: false },
{ name: "Titania", checked: false },
{ name: "Asterius DLC", checked: false },
{ name: "Yatagarasu", checked: false },
{ name: "Baphomet", checked: false },
{ name: "Melchizedek", checked: false },
{ name: "Black Rider", checked: false },
{ name: "Trumpeter", checked: false },
{ name: "Lilith", checked: false },
{ name: "Moloch", checked: false },
{ name: "Orichalcum", checked: false },
{ name: "King Frost", checked: false },
{ name: "Chernobog", checked: false },
{ name: "Seiryu", checked: false },
{ name: "Asterius Picaro DLC", checked: false },
{ name: "Forneus", checked: false },
{ name: "Kali", checked: false },
{ name: "Hanuman", checked: false },
{ name: "Thor", checked: false },
{ name: "Yamata-no-Orochi", checked: false },
{ name: "Atavaka", checked: false },
{ name: "Thanatos DLC", checked: false },
{ name: "Oberon", checked: false },
{ name: "Quetzalcoatl", checked: false },
{ name: "Bishamonten", checked: false },
{ name: "Black Frost", checked: false },
{ name: "Dominion", checked: false },
{ name: "Vasuki", checked: false },
{ name: "Lakshmi", checked: false },
{ name: "Thanatos Picaro DLC", checked: false },
{ name: "Byakhee", checked: false },
{ name: "Loa", checked: false },
{ name: "Dionysus", checked: false },
{ name: "Mot", checked: false },
{ name: "Throne", checked: false },
{ name: "Macabre", checked: false },
{ name: "Mara", checked: false },
{ name: "Chimera", checked: false },
{ name: "Nebiros", checked: false },
{ name: "Abaddon", checked: false },
{ name: "Sandalphon", checked: false },
{ name: "Asura", checked: false },
{ name: "Cu Chulainn", checked: false },
{ name: "Kohryu", checked: false },
{ name: "Raoul DLC", checked: false },
{ name: "Gabriel", checked: false },
{ name: "Scathach", checked: false },
{ name: "Raphael", checked: false },
{ name: "Sraosha", checked: false },
{ name: "Vohu Manah", checked: false },
{ name: "Zaou-Gongen", checked: false },
{ name: "Izanagi-no-Okami DLC", checked: false },
{ name: "Alilat", checked: false },
{ name: "Uriel", checked: false },
{ name: "Messiah DLC", checked: false },
{ name: "Attis", checked: false },
{ name: "Baal", checked: false },
{ name: "Belial", checked: false },
{ name: "Shiva", checked: false },
{ name: "Alice", checked: false },
{ name: "Cybele", checked: false },
{ name: "Surt", checked: false },
{ name: "Vishnu", checked: false },
{ name: "Ardha", checked: false },
{ name: "Hastur", checked: false },
{ name: "Odin", checked: false },
{ name: "Siegfried", checked: false },
{ name: "Ishtar", checked: false },
{ name: "Mother Harlot", checked: false },
{ name: "Fafnir", checked: false },
{ name: "Fut", checked: false },
{ name: "Beelzebub", checked: false },
{ name: "Michael", checked: false },
{ name: "Yoshit", checked: false },
{ name: "Chi You", checked: false },
{ name: "Metatron", checked: false },
{ name: "Ongyo-Ki", checked: false },
{ name: "Izanagi-no-Okami Picaro DLC", checked: false },
{ name: "Mada", checked: false },
{ name: "Messiah Picaro DLC", checked: false },
{ name: "Satan", checked: false },
{ name: "Lucifer", checked: false },
{ name: "Maria", checked: false },
{ name: "Satanael", checked: false },
  ];

  var characterList = document.getElementById("characterList");

  characters.forEach(function (character, index) {
    var characterItem = document.createElement("li");
    characterItem.className = "character-item";

    var checkbox = document.createElement("input");
    checkbox.type = "checkbox";
    checkbox.className = "character-checkbox";
    checkbox.id = "character-" + index;

    var nameLabel = document.createElement("label");
    nameLabel.className = "character-name";
    nameLabel.setAttribute("for", "character-" + index);
    nameLabel.textContent = character.name;

    characterItem.appendChild(checkbox);
    characterItem.appendChild(nameLabel);

    characterList.appendChild(characterItem);

    checkbox.addEventListener("change", function () {
      character.checked = checkbox.checked;
      nameLabel.classList.toggle("character-ticked", character.checked);
    });
  });
});
