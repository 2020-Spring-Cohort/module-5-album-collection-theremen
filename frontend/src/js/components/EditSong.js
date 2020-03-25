export default function EditSong(song){
    return `
    <section class="content__song">
        <h4>Edit Song</h4>
    </section>
    
    <section class="update-song">
        <input class="update-song__title" type="text" value="${song.songTitle}">
        <input class="update-song__link" type="text" value="${song.links}">
        <input class="update-song__duration" type="text" value="${song.duration}">
        <input class="update-song__id" type="hidden" value="${song.songId}">
        <input class="update-song__albumId" type="hidden" value="${song.albumId}">
        <button class="update-song__submit">Save Changes</button>
    </section>
`;
}